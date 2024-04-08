using MySql.Data.MySqlClient;
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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();

            surname_textbox.Text = "Введите фамилию";

            name_textbox.Text = "Введите имя";

            lastname_textbox.Text = "Введите отчество";

            faculty_textbox.Text = "Введите факультет";

            group_textbox.Text = "Введите группу";

            spec_textbox.Text = "Введите специальность";


        }



        private void age_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void surname_textbox_Enter(object sender, EventArgs e)
        {
            if (surname_textbox.Text == "Введите фамилию")
                surname_textbox.Text = "";
        }

        private void surname_textbox_Leave(object sender, EventArgs e)
        {
            if (surname_textbox.Text == "")
                surname_textbox.Text = "Введите фамилию";
        }

        private void name_textbox_Enter(object sender, EventArgs e)
        {
            if (name_textbox.Text == "Введите имя")
                name_textbox.Text = "";
        }

        private void name_textbox_Leave(object sender, EventArgs e)
        {
            if (name_textbox.Text == "")
                name_textbox.Text = "Введите имя";
        }

        private void lastname_textbox_Enter(object sender, EventArgs e)
        {
            if (lastname_textbox.Text == "Введите отчество")
                lastname_textbox.Text = "";
        }

        private void lastname_textbox_Leave(object sender, EventArgs e)
        {
            if (lastname_textbox.Text == "")
                lastname_textbox.Text = "Введите отчество";
        }

        private void faculty_textbox_Enter(object sender, EventArgs e)
        {
            if (faculty_textbox.Text == "Введите факультет")
                faculty_textbox.Text = "";
        }

        private void group_textbox_Enter(object sender, EventArgs e)
        {
            if (group_textbox.Text == "Введите группу")
                group_textbox.Text = "";
        }

        private void spec_textbox_Enter(object sender, EventArgs e)
        {
            if (spec_textbox.Text == "Введите специальность")
                spec_textbox.Text = "";
        }

        private void spec_textbox_Leave(object sender, EventArgs e)
        {
            if (spec_textbox.Text == "")
                spec_textbox.Text = "Введите специальность";
        }



        private void faculty_textbox_Leave(object sender, EventArgs e)
        {
            if (faculty_textbox.Text == "")
                faculty_textbox.Text = "Введите факультет";
        }

        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            this.Close();
            RootForm rootForm = new RootForm();
            rootForm.Show();

        }

        private void add_info_button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO students (surname, name, lastname, borndate, sex, faculty, groupnumber, specialty, isOffline) VALUES (@surname,@name, @lastname, @borndate,@sex,@faculty,@group,@spec,@isOffline);");
        
        command.Parameters.Add("surname", MySqlDbType.VarChar).Value = surname_textbox.Text;
        }
    }
}
