using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicineDatabaseApp
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void surname_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void lastname_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void age_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void radio_button_female_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void radio_button_male_CheckedChanged(object sender, EventArgs e)
        {
   
        }
    }
}
