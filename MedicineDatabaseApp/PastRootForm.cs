﻿using MedicineDatabaseApp.PastRootForms;
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
    }
}