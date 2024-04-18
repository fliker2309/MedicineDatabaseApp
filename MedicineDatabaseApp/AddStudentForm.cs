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
            int startYear = 2014;
            int endYear = DateTime.Now.Year;

            for (int year = startYear; year <= endYear; year++)
            {
                admissionYearBox.Items.Add(year.ToString());
            }

            ComboBox facultyBox = new ComboBox();
            initialize_faculties();

            ComboBox specialityBox = new ComboBox();
            initialize_specialities();

        }    

        private void initialize_faculties()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT faculty FROM faculties", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            List<string> faculties = new List<string>();
            while (reader.Read())
            {
                faculties.Add(reader.GetString(0));
            }
            facultyBox.DataSource = faculties;

            db.closeConnection();
        }

        private void initialize_specialities()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT speciality FROM specialities", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            List<string> specialities = new List<string>();
            while (reader.Read())
            {
                specialities.Add(reader.GetString(0));
            }
            specialityBox.DataSource = specialities;
            db.closeConnection();

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

      

        private void group_textbox_Enter(object sender, EventArgs e)
        {
            if (group_textbox.Text == "Введите группу")
                group_textbox.Text = "";
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


            MySqlCommand command = new MySqlCommand("INSERT INTO students (surname, name, lastname, age, admission_year, sex, faculty, groupnumber, speciality, isOffline) VALUES (@surname,@name, @lastname, @age,@admissionyear, @sex,@faculty,@group,@spec,@isOffline);", db.getConnection());

            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname_textbox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_textbox.Text;
            command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname_textbox.Text;
            command.Parameters.Add("@age", MySqlDbType.Date).Value = borndate_datepicker.Value;
            command.Parameters.Add("@admissionyear", MySqlDbType.VarChar).Value = selectedYear;

          
            string sex = male_radiobutton.Checked ? "Мужской" : "Женский";
            command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;


            command.Parameters.Add("@faculty", MySqlDbType.VarChar).Value = facultyBox.SelectedItem.ToString();
            command.Parameters.Add("@group", MySqlDbType.VarChar).Value = group_textbox.Text;
            command.Parameters.Add("@spec", MySqlDbType.VarChar).Value = specialityBox.SelectedItem.ToString();

            string isOffline = offline_radiobutton.Checked ? "Очное" : "Заочное";
            command.Parameters.Add("@isOffline", MySqlDbType.VarChar).Value = isOffline;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Студент добавлен");

                this.Close();            
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
