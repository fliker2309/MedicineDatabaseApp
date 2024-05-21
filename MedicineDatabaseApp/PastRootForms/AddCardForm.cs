using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineDatabaseApp
{
    public partial class AddCardForm : Form
    {
        public AddCardForm()
        {
            InitializeComponent();
       
            initialize_students();
            studentBox.SelectedIndex = -1;
        }


        private void initialize_students()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT id, CONCAT(surname, ' ', name, ' ', lastname) as fullname FROM students WHERE hasmedicalcard = 0", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable students = new DataTable();
            students.Load(reader); // Загрузите данные в DataTable
            studentBox.DataSource = students; // Используйте DataTable в качестве источника данных
            studentBox.DisplayMember = "fullname"; // Отображаемое значение - это полное имя студента
            studentBox.ValueMember = "id"; // Сохраняемое значение - это id студента
            db.closeConnection();
        }

        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            this.Close();
            PastRootForm rootForm = new PastRootForm();
            rootForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получите id выбранного студента
            int studentId = (int)studentBox.SelectedValue;

            // Создайте SQL-запрос для обновления столбца hasmedicalcard
            string updateQuery = "UPDATE students SET hasmedicalcard = 1 WHERE id = @id";

            // Создайте SQL-запрос для вставки новой записи в таблицу medicalcard
            string insertQuery = "INSERT INTO medicalcards (student_id) VALUES (@id)";

            // Выполните запросы
            DB db = new DB();
            MySqlCommand updateCommand = new MySqlCommand(updateQuery, db.getConnection());
            MySqlCommand insertCommand = new MySqlCommand(insertQuery, db.getConnection());
            updateCommand.Parameters.AddWithValue("@id", studentId);
            insertCommand.Parameters.AddWithValue("@id", studentId);
            db.openConnection();
            if (updateCommand.ExecuteNonQuery() == 1 && insertCommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Медицинская карта добавлена");
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении медицинской карты");
            }
            db.closeConnection();
        }
    }
}
