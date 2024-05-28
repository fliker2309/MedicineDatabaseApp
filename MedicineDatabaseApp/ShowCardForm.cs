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

namespace MedicineDatabaseApp
{
    public partial class ShowCardForm : Form
    {
//        public ShowCardForm()
//        {
//            this.medicalcardsId = medicalcardsId;
//            this.Load += new EventHandler(medicalcardsForm_Load);
//            InitializeComponent();
//        }
        

//            private void medicalcardsForm_Load(object sender, EventArgs e)
//            {
//                string query = @"
//SELECT medicalcards.*, medicalcards.student_id, specialities.speciality
//FROM medicalcards
//INNER JOIN faculties ON students.faculty_id = faculties.id
//INNER JOIN specialities ON students.speciality_id = specialities.id
//WHERE students.id = @id";

//                DB db = new DB();
//                MySqlCommand command = new MySqlCommand(query, db.getConnection());
//                command.Parameters.AddWithValue("@id", studentId);
//                db.openConnection();
//                using (var reader = command.ExecuteReader())
//                {
//                    if (reader.Read())
//                    {
//                        surname_label.Text = reader["surname"].ToString();
//                        name_label.Text = reader["name"].ToString();
//                        lastname_label.Text = reader["lastname"].ToString();

//                        DateTime birthDate = Convert.ToDateTime(reader["age"]);
//                        age_label.Text = birthDate.ToString("dd.MM.yyyy");

//                        label_sex.Text = reader["sex"].ToString();

//                        faculcy_label.Text = reader["faculty"].ToString();
//                        spec_label.Text = reader["speciality"].ToString();

//                        group_label.Text = reader["groupnumber"].ToString();

//                        learning_form_label.Text = reader["aducation_form"].ToString();
//                        start_label.Text = reader["start_year"].ToString();
//                        end_label.Text = reader["end_year"].ToString();

//                    }
//                }
//                db.closeConnection();
//            }

          
            private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
