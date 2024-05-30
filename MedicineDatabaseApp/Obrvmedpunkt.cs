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
    public partial class Obrvmedpunkt : Form
    {
        public Obrvmedpunkt()
        {
            InitializeComponent();
            initialize_vrach();
            initialize_students();
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                MySqlCommand command = new MySqlCommand("INSERT INTO health_visits (card_id, complaints, symptoms, body_temperature, body_pressure, diagnos, recommendations, doctor_id, visit_date, surgical_intervention) VALUES(@id, @complaintsD, @symptomsD, @body_temperatureD, @body_pressureD, @diagnosD, @recommendationsD, @doctorD, @visit_dateD, @surgical_interventionD);", db.getConnection());
                command.Parameters.AddWithValue("@id", cardId);
                command.Parameters.Add("@complaintsD", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@symptomsD", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@body_temperatureD", MySqlDbType.VarChar).Value = textBox4.Text;
                command.Parameters.Add("@body_pressureD", MySqlDbType.VarChar).Value = textBox5.Text;
                command.Parameters.Add("@diagnosD", MySqlDbType.VarChar).Value = textBox6.Text;
                command.Parameters.Add("@recommendationsD", MySqlDbType.VarChar).Value = textBox7.Text;
                command.Parameters.Add("@doctorD", MySqlDbType.Int32).Value = (int)comboBox2.SelectedValue;
                command.Parameters.Add("@visit_dateD", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@surgical_interventionD", MySqlDbType.VarChar).Value = textBox8.Text;
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Обращение добавлено");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Обращение не добавлено");
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



