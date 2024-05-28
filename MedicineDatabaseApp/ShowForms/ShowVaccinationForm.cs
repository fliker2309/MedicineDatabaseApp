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
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

