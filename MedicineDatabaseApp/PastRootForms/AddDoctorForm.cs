using MySql.Data.MySqlClient;

namespace MedicineDatabaseApp.PastRootForms
{
    public partial class AddDoctorForm : Form
    {
        public AddDoctorForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            this.Close();
            PastRootForm form = new PastRootForm();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surname_textbox.Text) &&
                string.IsNullOrWhiteSpace(nameTB.Text) &&
                string.IsNullOrWhiteSpace(lastnameTB.Text) &&
                string.IsNullOrWhiteSpace(jobtitleTB.Text) &&
                string.IsNullOrWhiteSpace(qualityTB.Text)
                ) { MessageBox.Show("Заполните все поля!"); 
            }           
                         
                else
            {
                DB db = new DB();

                MySqlCommand command = new MySqlCommand("INSERT INTO doctors (surname, name, lastname, age, job_title, qualification, work_experience) VALUES(@surname, @name, @lastname, @age, @job_title, @qualification, @work_experience);", db.getConnection());
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname_textbox.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameTB.Text;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastnameTB.Text;
                command.Parameters.Add("@age", MySqlDbType.Date).Value = borndate_datepicker.Value;
                command.Parameters.Add("@job_title", MySqlDbType.VarChar).Value = jobtitleTB.Text;
                command.Parameters.Add("@qualification", MySqlDbType.VarChar).Value = qualityTB.Text;
                command.Parameters.Add("@work_experience", MySqlDbType.Date).Value = expTimePicker.Value;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Врач добавлен");

                    this.Close();
                    PastRootForm rootForm = new PastRootForm();
                    rootForm.Show();
                }
                else
                {
                    MessageBox.Show("Врач не добавлен");
                }
                db.closeConnection();
            }
        }
    }
}
