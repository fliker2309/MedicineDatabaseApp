using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MedicineDatabaseApp.PastRootForms;
using MySql.Data.MySqlClient;

namespace MedicineDatabaseApp.ShowForms
{
    public partial class ShowVaccinationForm : Form
    {
        private int studentId;

        public ShowVaccinationForm(int studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            vaccinationsListView.MouseDoubleClick += Vaccination_MouseDoubleClick;
            this.Load += new EventHandler(ShowVaccinationForm_load);
            this.Load += new EventHandler(VaccinationForm_load);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Vaccination_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (vaccinationsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = vaccinationsListView.SelectedItems[0];
                dateTimePicker1.Text = item.SubItems[0].Text;
                textBox1.Text = item.SubItems[1].Text;


            }
        }
        private void VaccinationForm_load(object sender, EventArgs e)
        {

            vaccinationsListView.View = View.Details;
            vaccinationsListView.Columns.Add("Дата прививки");
            vaccinationsListView.Columns.Add("Тип прививки");
            ResizeListViewColumns(vaccinationsListView);


            string queryCardId = "SELECT card_id FROM medicalcards WHERE student_id = @studentId";
            string queryVaccinations = "SELECT * FROM vaccination WHERE card_id = @cardId";
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(queryCardId, db.getConnection());
            // Исправление здесь: параметр должен быть "@studentId", а не "@id"
            command.Parameters.AddWithValue("@studentId", studentId);

            db.openConnection();
            int cardId = 0;

            // Получение card_id
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    cardId = int.Parse(reader["card_id"].ToString());
                }
            }

            // Если card_id найден, получаем данные о прививках
            if (cardId > 0)
            {
                command.CommandText = queryVaccinations;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@cardId", cardId); // Исправление здесь: параметр должен быть "@cardId"

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Преобразование строки в DateTime
                        DateTime vaccinationDate = DateTime.Parse(reader["vaccination_date"].ToString());
                        // Форматирование DateTime в строку только с датой
                        string formattedDate = vaccinationDate.ToString("dd.MM.yyyy");

                        // Создание нового элемента для ListView
                        ListViewItem item = new ListViewItem(formattedDate);
                        item.SubItems.Add(reader["vaccination_type"].ToString());
                        // Добавление элемента в ListView
                        item.Tag = reader["id"];
                        vaccinationsListView.Items.Add(item);
                    }
                }
            }

            db.closeConnection();
        }
        private void ResizeListViewColumns(System.Windows.Forms.ListView listView)
        {

            int totalColumnWidth = listView.Width - SystemInformation.VerticalScrollBarWidth;

            int columnWidth = totalColumnWidth / listView.Columns.Count;

            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void ShowVaccinationForm_load(object sender, EventArgs e)
        {
            string query = @"
            SELECT  
            CONCAT(surname, ' ', name, ' ', lastname) 
            AS FullName 
            FROM students
            WHERE students.id = @id";

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("@id", studentId);
            db.openConnection();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    studentName.Text = reader["FullName"].ToString();
                }
            }
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (vaccinationsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = vaccinationsListView.SelectedItems[0];
                int idValue = (int)item.Tag; // Получаем id из свойства Tag выбранного элемента

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE vaccination SET vaccination_type = @vaccination_typeR, vaccination_date = @vaccination_dateR WHERE id = @id;", db.getConnection());
                command.Parameters.Add("@vaccination_typeR", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@vaccination_dateR", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idValue; // Используем полученное id
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (dateTimePicker1.Text == "")
                    {
                        MessageBox.Show("Введите дату");
                    }
                    else
                    {
                        MessageBox.Show("Прививка изменена");
                        this.Close();
                    }
                    textBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите тип прививки");
                }

                db.closeConnection();
            }
        }
        private void DeletePrivivka(int surnameId)
        {
            DB db = new DB();
            string deleteQuery = "DELETE FROM vaccination WHERE id = @id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", surnameId);
            db.openConnection();
            deleteCommand.ExecuteNonQuery();
            db.closeConnection();
            textBox1.Text = "";
            dateTimePicker1.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (vaccinationsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = vaccinationsListView.SelectedItems[0];
                int surnameId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить справку", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeletePrivivka(surnameId);
                    vaccinationsListView.Items.Remove(item);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AddVaccinationForm form = new AddVaccinationForm();
            form.Show();
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            
        }
    }


