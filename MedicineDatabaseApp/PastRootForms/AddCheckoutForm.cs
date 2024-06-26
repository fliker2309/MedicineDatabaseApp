﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;

namespace MedicineDatabaseApp
{
    public partial class AddCheckoutForm : Form
    {
        public AddCheckoutForm()
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
        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cardId = (int)comboBox1.SelectedValue;

            if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Заполните все поля!");

            }
            else
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("INSERT INTO body_check (card_id, date_of_issue, doctor_id, group_fizkult, suitability, prichina) VALUES(@id, @date_of_issueR, @doctorR, @group_fizkultR, @suitabilityR, @prichinaR);", db.getConnection());
                command.Parameters.AddWithValue("@id", cardId);
                command.Parameters.Add("@date_of_issueR", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@doctorR", MySqlDbType.Int32).Value = (int)comboBox2.SelectedValue;
                command.Parameters.Add("@group_fizkultR", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@suitabilityR", MySqlDbType.VarChar).Value = textBox2.Text; 
                command.Parameters.Add("@prichinaR", MySqlDbType.VarChar).Value = textBox3.Text;
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Медосмотр добавлен");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Медосмотр не добавлен");
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
