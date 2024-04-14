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
using System.Xml;

namespace MedicineDatabaseApp
{
    public partial class ShowStudentsForm : Form
    {
        private DB db;
        public ShowStudentsForm()
        {
            InitializeComponent();
            db = new DB();
            loadStudents();
            // Заполнение элементов управления данными студента
            /*surnameLabel.Text = student.Surname;
            nameLabel.Text = student.Name;
            lastnameLabel.Text = student.Lastname;
            borndateLabel.Text = student.Borndate.ToString("dd.MM.yyyy");
            sexLabel.Text = student.Sex;
            facultyLabel.Text = student.Faculty;
            groupLabel.Text = student.Group;
            specLabel.Text = student.Specialty;
            isOfflineLabel.Text = student.IsOffline ? "Заочная" : "Очная";*/

        }

        private void loadStudents()
        {


            MySqlCommand command = new MySqlCommand("SELECT * FROM students", db.getConnection());

            db.openConnection();

            using (var reader = command.ExecuteReader())
            {
                var dataTable = new DataTable();
                dataTable.Load(reader);

                studentsDataGridView.DataSource = dataTable;
            }

            db.closeConnection();
        }

        private void toMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
            RootForm rootForm = new RootForm();
            rootForm.Show();
        }
    }
}
