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
    }
}
