using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineDatabaseApp.ShowForms
{
    public partial class ShowVaccinationForm : Form
    {
        private int _studentId;

        public ShowVaccinationForm(int studentId)
        {
            _studentId = studentId;
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

