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

namespace MedicineDatabaseApp.ShowForms
{
    public partial class ShowVaccinationForm : Form
    {
        private int studentId;

        public ShowVaccinationForm(int studentId)
        {
            this.studentId = studentId;
            this.Load += new EventHandler(ShowVaccinationForm_load);
            this.Load += new EventHandler(VaccinationForm_load);
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}

