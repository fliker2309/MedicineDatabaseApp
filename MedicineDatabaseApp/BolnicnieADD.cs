using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicineDatabaseApp
{
    public partial class BolnicnieADD : Form
    {
        private Form StudentDetailsForm;
        public BolnicnieADD()
        {
            InitializeComponent();
            initialize_students();
            initialize_vrach();
            this.StudentDetailsForm = StudentDetailsForm;
        }
        private void initialize_students()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT  card_id, CONCAT(surname, ' ', name, ' ', lastname) as fullname FROM students INNER JOIN medicalcards ON students.id = medicalcards.student_id", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable students = new DataTable();
            students.Load(reader);
            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "fullname";
            comboBox1.ValueMember = "card_id";
            db.closeConnection();
        }
        private void initialize_vrach()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT id, CONCAT(surname, ' ', name, ' ', lastname) AS fullname FROM doctors", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable surname = new DataTable();
            surname.Load(reader);
            comboBox2.DataSource = surname;
            comboBox2.DisplayMember = "fullname";
            comboBox2.ValueMember = "id";

            db.closeConnection();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int cardId = (int)comboBox1.SelectedValue;

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Заполните все поля!");

            }
            else
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO sick_leave (sick_number, sick_type, sick_start, sick_end, card_id, doctor_id) VALUES(@sick_numberD, @sick_typeD, @sick_startD, @sick_endD, @id, @doctorD);", db.getConnection());
                command.Parameters.Add("@sick_numberD", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@sick_typeD", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@sick_startD", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@sick_endD", MySqlDbType.Date).Value = dateTimePicker2.Value;
                command.Parameters.AddWithValue("@id", cardId);
                command.Parameters.Add("@doctorD", MySqlDbType.Int32).Value = (int)comboBox2.SelectedValue;
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Больничный добавлен");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Больничный не добавлен");
                }
                db.closeConnection();

            }
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
