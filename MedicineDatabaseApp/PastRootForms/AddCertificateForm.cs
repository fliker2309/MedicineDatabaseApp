﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MedicineDatabaseApp.PastRootForms;
using MySql.Data.MySqlClient;


namespace MedicineDatabaseApp
{
    public partial class AddCertificateForm : Form
    {
        private Form StudentDetailsForm;
        public AddCertificateForm()
        {
            InitializeComponent();
            initialize_students();
            initialize_vrach();
            this.StudentDetailsForm = StudentDetailsForm;
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
            comboBox2.DataSource = students;
            comboBox2.DisplayMember = "fullname";
            comboBox2.ValueMember = "card_id";
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
            comboBox1.DataSource = surname;
            comboBox1.DisplayMember = "fullname";
            comboBox1.ValueMember = "id";

            db.closeConnection();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cardId = (int)comboBox2.SelectedValue;

            if (string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                MessageBox.Show("Заполните все поля!");

            }
            else
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO certificates (card_id, date_of_issue, illness, doctor_id, health_status, conclusion) VALUES(@id, @date_of_issueD, @illnessD, @doctorD, @health_statusD, @conclusionD);", db.getConnection());
                command.Parameters.AddWithValue("@id", cardId);
                command.Parameters.Add("@date_of_issueD", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@illnessD", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@doctorD", MySqlDbType.Int32).Value = (int)comboBox1.SelectedValue;
                command.Parameters.Add("@health_statusD", MySqlDbType.VarChar).Value = textBox3.Text;
                command.Parameters.Add("@conclusionD", MySqlDbType.VarChar).Value = textBox4.Text;
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Справка добавлена");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Справка не добавлена");
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
