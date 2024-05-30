using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineDatabaseApp.PastRootForms
{
    public partial class AddVaccinationForm : Form
    {
        public AddVaccinationForm()
        {
            InitializeComponent();

            initialize_students();

        }

        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void initialize_students()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT  card_id, CONCAT(surname, ' ', name, ' ', lastname) as fullname FROM students INNER JOIN medicalcards ON students.id = medicalcards.student_id", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable students = new DataTable();
            students.Load(reader);
            studentBox.DataSource = students;
            studentBox.DisplayMember = "fullname";
            studentBox.ValueMember = "card_id";
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cardId = (int)studentBox.SelectedValue;

            if (string.IsNullOrWhiteSpace(typeTB.Text))
            {
                MessageBox.Show("Заполните все поля!");

            }
            else
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO vaccination (card_id, vaccination_type, vaccination_date) VALUES (@id, @vaccinationType, @vaccinationDate);", db.getConnection());
                command.Parameters.AddWithValue("@id", cardId);
                command.Parameters.Add("@vaccinationType", MySqlDbType.VarChar).Value = typeTB.Text;
                command.Parameters.Add("@vaccinationDate", MySqlDbType.Date).Value = vaccine_date.Value;
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Прививка добавлена");

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Прививка не добавлена");
                }
                db.closeConnection();

            }
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
