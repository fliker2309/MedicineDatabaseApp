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

            }
        }
    }
}
