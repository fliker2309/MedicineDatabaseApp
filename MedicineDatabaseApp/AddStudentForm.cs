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

            group_textbox.Text = "Введите группу";

            ComboBox admissionYear = new ComboBox();
            int startYear = 2000;
            int endYear = DateTime.Now.Year;

            for (int year = startYear; year <= endYear; year++)
            {
                admissionYearBox.Items.Add(year.ToString());
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
          /*  if (faculty_textbox.Text == "Введите факультет")
                faculty_textbox.Text = "";*/
        }

        private void group_textbox_Enter(object sender, EventArgs e)
        {
            if (group_textbox.Text == "Введите группу")
                group_textbox.Text = "";
        }

        private void spec_textbox_Enter(object sender, EventArgs e)
        {
           /* if (spec_textbox.Text == "Введите специальность")
                spec_textbox.Text = "";*/
        }

        private void spec_textbox_Leave(object sender, EventArgs e)
        {
          /*  if (spec_textbox.Text == "")
                spec_textbox.Text = "Введите специальность";*/
        }



        private void faculty_textbox_Leave(object sender, EventArgs e)
        {
     /*       if (faculty_textbox.Text == "")
                faculty_textbox.Text = "Введите факультет";*/
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

            int selectedYear = int.Parse(admissionYearBox.SelectedItem.ToString());


            MySqlCommand command = new MySqlCommand("INSERT INTO students (surname, name, lastname, borndate, admission_year, sex, faculty, groupnumber, specialty, isOffline) VALUES (@surname,@name, @lastname, @borndate,@admissionyear, @sex,@faculty,@group,@spec,@isOffline);", db.getConnection());

            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname_textbox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_textbox.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname_textbox.Text;
            command.Parameters.Add("@borndate", MySqlDbType.Date).Value = borndate_datepicker.Value;
            command.Parameters.Add("@admissionyear", MySqlDbType.VarChar).Value = selectedYear;


            // Проверяем, какая радиокнопка выбрана
            string sex = male_radiobutton.Checked ? "Мужской" : "Женский";
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;

            command.Parameters.Add("@faculty", MySqlDbType.VarChar).Value = facultyBox.Text;
            command.Parameters.Add("@group", MySqlDbType.VarChar).Value = group_textbox.Text;
            command.Parameters.Add("@spec", MySqlDbType.VarChar).Value = specialityBox.Text;

            string isOffline = offline_radiobutton.Checked ? "Очное" : "Заочное";
            command.Parameters.Add("@isOffline", MySqlDbType.VarChar).Value = isOffline;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Студент добавлен");

                // Закрытие текущей формы
                this.Close();

                // Открытие rootForm
                RootForm rootForm = new RootForm();
                rootForm.Show();
            }
            else
            {
                MessageBox.Show("Студент не добавлен");
            }

            db.closeConnection();

        }
    }
}
