using MedicineDatabaseApp.PastRootForms;
using System;
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
    public partial class PastRootForm : Form
    {
        public PastRootForm()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            RootForm form = new RootForm();
            form.ShowDialog();
        }

        private void toAddDoctorForm(object sender, EventArgs e)
        {
            this.Close();
            AddDoctorForm form = new AddDoctorForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddFacultyForm form = new AddFacultyForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AddSpecialityForm form = new AddSpecialityForm();
            form.Show();
        }

        private void closeAppBtn_MouseHover(object sender, EventArgs e)
        {
            closeAppBtn.Cursor = Cursors.Hand;
        }

        private void closeAppBtn_MouseLeave(object sender, EventArgs e)
        {
            closeAppBtn.Cursor = Cursors.Default;
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            AddVaccinationForm form = new AddVaccinationForm();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            AddCertificateForm form = new AddCertificateForm();
            form.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Obrvmedpunkt form = new Obrvmedpunkt();
            form.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
