﻿using System;
using MySql.Data.MySqlClient;
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
    public partial class StudentDetailsForm : Form
    {
        private int studentId;
        public StudentDetailsForm(int studentId)
        {
            this.studentId = studentId;
            this.Load += new EventHandler(StudentDetailsForm_Load);
            InitializeComponent();
        }

        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM students WHERE id = @id";
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("@id", studentId);
            db.openConnection();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    surname_label.Text = reader["surname"].ToString();
                    name_label.Text = reader["name"].ToString();
                    lastname_label.Text = reader["lastname"].ToString();

                    DateTime birthDate = Convert.ToDateTime(reader["age"]);
                    age_label.Text = birthDate.ToString("dd.MM.yyyy");

                    label_sex.Text = reader["sex"].ToString();

                }
            }
            db.closeConnection();
        }

        private void showCardBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowCardForm form = new ShowCardForm();
            form.ShowDialog();
        }

        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}