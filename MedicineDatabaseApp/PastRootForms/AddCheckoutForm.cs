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
    public partial class AddCheckoutForm : Form
    {
        public AddCheckoutForm()
        {
            InitializeComponent();
        }

        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            this.Close();
            RootForm rootForm = new RootForm();
            rootForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
