using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineDatabaseApp.PastRootForms
{
    public partial class AddFacultyForm : Form
    {
        public AddFacultyForm()
        {
            InitializeComponent();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            EditFacultyForm form = new EditFacultyForm();
            form.ShowDialog();
            form.BringToFront();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            PastRootForm form = new PastRootForm();
            form.Show();
        }

        private void addFacultyBtn_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO faculties (faculty) VALUES (@faculty);", db.getConnection());
            command.Parameters.Add("@faculty", MySqlDbType.VarChar).Value = facultyTextBox.Text;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                if (facultyTextBox.Text == "")
                {
                    MessageBox.Show("Введите факультет");
                }
                else
                {
                    MessageBox.Show("Факультет добавлен");
                    this.Close();
                    PastRootForm form = new PastRootForm();
                    form.Show();
                }

            }
            else
            {
                MessageBox.Show("Введите факультет");
            }

            db.closeConnection();
        }
    }
}
