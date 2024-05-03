﻿using System;
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
    public partial class RootForm : Form
    {
        public RootForm()
        {
            InitializeComponent();
        }

        private void toAddForm_Click(object sender, EventArgs e)
        {

            AddStudentForm addForm = new AddStudentForm();
            addForm.Show();
            this.Hide();
        }

        private void toPastRootForm(object sender, EventArgs e)
        {
           //путь к форме наполнения данных            this.Hide();
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toAddChechupForm_Click(object sender, EventArgs e)
        {
            AddCheckoutForm addForm = new AddCheckoutForm();
            addForm.Show();
            this.Hide();
        }

        private void toCardAddForm_Click(object sender, EventArgs e)
        {
            AddCardForm addForm = new AddCardForm();
            addForm.Show();
            this.Hide();
        }

        private void toAddCertificateForm_Click(object sender, EventArgs e)
        {
            AddCertificateForm addForm = new AddCertificateForm();
            addForm.Show();
            this.Hide();
        }


        private void addSpecialityBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSpecialityForm addForm = new AddSpecialityForm();
            addForm.Show();
        }

        private void addFaculcyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFacultyForm addForm = new AddFacultyForm();
            addForm.Show();
        }

        private void toSearchWithParameters_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForm searchForm = new SearchForm();
            searchForm.Show();
        }    
              
    }
}
