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

namespace MedicineDatabaseApp.ShowForms
{
    public partial class spravkiform : Form
    {
        private int studentId;
        public spravkiform(int studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            spravkiListView.MouseDoubleClick += EditVrachForm_MouseDoubleClick;
            this.studentId = studentId;
            this.Load += new EventHandler(spravkiform_load);
            this.Load += new EventHandler(spravkiformForm_load);


        }
        private void initialize_vrach()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT id, CONCAT(surname, ' ', name, ' ', lastname) AS fullname FROM doctors", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable surname = new DataTable();
            surname.Load(reader);
            comboBox1.DataSource = surname;
            comboBox1.DisplayMember = "fullname";
            comboBox1.ValueMember = "id";

            db.closeConnection();
        }
        private void EditVrachForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (spravkiListView.SelectedItems.Count > 0)
            {
                initialize_vrach();
                ListViewItem item = spravkiListView.SelectedItems[0];
                dateTimePicker1.Text = item.SubItems[0].Text;
                textBox2.Text = item.SubItems[1].Text;
                comboBox1.Text = item.SubItems[2].Text;
                textBox4.Text = item.SubItems[3].Text;
                textBox5.Text = item.SubItems[4].Text;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void spravkiformForm_load(object sender, EventArgs e)
        {
            spravkiListView.View = View.Details;
            spravkiListView.Columns.Add("Дата справки");
            spravkiListView.Columns.Add("Болезнь");
            spravkiListView.Columns.Add("Доктор");
            spravkiListView.Columns.Add("Состояния здоровья");
            spravkiListView.Columns.Add("Заключение");

            ResizeListViewColumns(spravkiListView);

            string queryCardId = "SELECT card_id FROM medicalcards WHERE student_id = @studentId";
            string querySpravka = "SELECT certificates.*, CONCAT(doctors.surname, ' ', doctors.name, ' ', doctors.lastname) AS doctor_fullname FROM certificates JOIN doctors ON certificates.doctor_id = doctors.id WHERE card_id = @cardId";
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(queryCardId, db.getConnection());
            command.Parameters.AddWithValue("@studentId", studentId);

            db.openConnection();
            int cardId = 0;

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    cardId = int.Parse(reader["card_id"].ToString());
                }
            }

            if (cardId > 0)
            {
                command.CommandText = querySpravka;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@cardId", cardId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime SpravkaDate = DateTime.Parse(reader["date_of_issue"].ToString());
                        string formattedDate = SpravkaDate.ToString("dd.MM.yyyy");

                        ListViewItem item = new ListViewItem(formattedDate);
                        item.SubItems.Add(reader["illness"].ToString());
                        item.SubItems.Add(reader["doctor_fullname"].ToString());
                        item.SubItems.Add(reader["health_status"].ToString());
                        item.SubItems.Add(reader["conclusion"].ToString());
                        item.Tag = reader["id"];
                        spravkiListView.Items.Add(item);
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

        private void spravkiform_load(object sender, EventArgs e)
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
                    label2.Text = reader["FullName"].ToString();
                }
            }
            db.closeConnection();
        }

        private void spravkiform_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (spravkiListView.SelectedItems.Count > 0)
            {
                ListViewItem item = spravkiListView.SelectedItems[0];
                int surnameId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить справку", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteSpravky(surnameId);
                    spravkiListView.Items.Remove(item);
                }
            }
        }
        private void DeleteSpravky(int surnameId)
        {
            DB db = new DB();
            string deleteQuery = "DELETE FROM certificates WHERE id = @id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", surnameId);
            db.openConnection();
            deleteCommand.ExecuteNonQuery();
            db.closeConnection();
            dateTimePicker1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (spravkiListView.SelectedItems.Count > 0)
            {
                ListViewItem item = spravkiListView.SelectedItems[0];
                int idValue = (int)item.Tag; // Получаем id из свойства Tag выбранного элемента

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE certificates SET date_of_issue = @date_of_issueR, illness = @illnessR, doctor_id = @doctor_idR, health_status = @health_statusR, conclusion = @conclusionR WHERE id = @id;", db.getConnection());
                command.Parameters.Add("@date_of_issueR", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@illnessR", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@doctor_idR", MySqlDbType.Int32).Value = (int)comboBox1.SelectedValue;
                command.Parameters.Add("@health_statusR", MySqlDbType.VarChar).Value = textBox4.Text;
                command.Parameters.Add("@conclusionR", MySqlDbType.VarChar).Value = textBox5.Text;
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
                        MessageBox.Show("Справка изменена");
                        this.Close();
                    }
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите болезнь");
                }

                db.closeConnection();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            AddCertificateForm form = new AddCertificateForm();
            form.Show();

        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }




}

