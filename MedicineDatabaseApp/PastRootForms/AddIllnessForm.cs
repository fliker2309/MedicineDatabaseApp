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

namespace MedicineDatabaseApp
{
    public partial class AddIllnessForm : Form
    {
        public AddIllnessForm()
        {
            InitializeComponent();

            initialize_students();
        }    

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            PastRootForm rootForm = new PastRootForm();
            rootForm.Show();
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
    }
}
