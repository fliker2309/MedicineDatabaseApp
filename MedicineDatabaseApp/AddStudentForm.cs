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

        private int? _studentId = null;
        private SearchForm _searchForm;
        public AddStudentForm()
        {
            InitializeComponent();

            surname_textbox.Text = "Введите фамилию";

            name_textbox.Text = "Введите имя";

            lastname_textbox.Text = "Введите отчество";

            group_textbox.Text = "Введите группу";           
                      
            initialize_faculties();
       
            initialize_specialities();

            initialize_ages();

        }

    private void initialize_ages()
        {
            ComboBox startYear = new ComboBox();
            int startYear1 = 2020;
            int endYear1 = DateTime.Now.Year;

            for (int year = startYear1; year <= endYear1; year++)
            {
                startYearBox.Items.Add(year.ToString());
            }

            ComboBox endYear = new ComboBox();
            int startYear2 = DateTime.Now.Year;
            int endYear2 = 2030;

            for (int year = startYear2; year <= endYear2; year++)
            {
                endYearBox.Items.Add(year.ToString());
            }
        }

    public AddStudentForm(int studentId, SearchForm searchForm)
        {
            _studentId = studentId;
            _searchForm = searchForm;
            this.Load += new EventHandler(StudentEditLoad);
            this.FormClosed += new FormClosedEventHandler(AddStudentForm_FormClosed);
            InitializeComponent();

            initialize_faculties();

            initialize_specialities();

            initialize_ages();
         
        }

        private void AddStudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _searchForm.updateListView();
        }

        private void StudentEditLoad(object sender, EventArgs e)
        {
            string query = @"
SELECT students.*, faculties.faculty, specialities.speciality
FROM students
INNER JOIN faculties ON students.faculty_id = faculties.id
INNER JOIN specialities ON students.speciality_id = specialities.id
WHERE students.id = @id";

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("@id", _studentId);
            db.openConnection();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    surname_textbox.Text = reader["surname"].ToString();
                    name_textbox.Text = reader["name"].ToString();
                    lastname_textbox.Text = reader["lastname"].ToString();

                    DateTime dateOfBirth = Convert.ToDateTime(reader["age"]);                  
                    borndate_datepicker.Value = dateOfBirth;

                    string sex = reader["sex"].ToString();
                    if(sex == "Мужской")
                    {
                        male_radiobutton.Checked = true;
                    }
                    else if (sex =="Женский")
                    {
                        radio_button_female.Checked = true;
                    }

                    facultyBox.Text = reader["faculty"].ToString();
                    specialityBox.Text = reader["speciality"].ToString();
                    group_textbox.Text = reader["groupnumber"].ToString();

                    string aducation = reader["aducation_form"].ToString();
                    if(aducation == "Очное")
                    {
                        offline_radiobutton.Checked = true ;
                    } else if (aducation == "Заочное")
                    {
                        online_radiobutton.Checked = true;
                    }

                    startYearBox.Text = reader["start_year"].ToString();
                    endYearBox.Text = reader["end_year"].ToString();
                }
            }
            db.closeConnection();
        }

        private void initialize_faculties()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT id, faculty FROM faculties", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable faculties = new DataTable();
            faculties.Load(reader); 
            facultyBox.DataSource = faculties; 
            facultyBox.DisplayMember = "faculty"; 
            facultyBox.ValueMember = "id"; 

            db.closeConnection();
        }
        private void initialize_specialities()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT id, speciality FROM specialities", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable specialities = new DataTable();
            specialities.Load(reader); 
            specialityBox.DataSource = specialities; 
            specialityBox.DisplayMember = "speciality"; 
            specialityBox.ValueMember = "id";

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

        private void group_textbox_Leave_1(object sender, EventArgs e)
        {
            if (group_textbox.Text == "")
                group_textbox.Text = "Введите группу";
        }

        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            if (_studentId.HasValue)
            {
                this.Close();
            }else
            {
                this.Close();
                RootForm rootForm = new RootForm();
                rootForm.Show();
            }

            
        }

        private void add_info_button_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command;
            if (_studentId.HasValue)
            {
                command = new MySqlCommand("UPDATE students SET surname = @surname, name = @name, lastname = @lastname, age = @age, sex = @sex, faculty_id = @faculty, speciality_id = @spec, groupnumber = @group, aducation_form = @aducationform, start_year = @startyear, end_year = @endyear WHERE id = @id;", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = _studentId.Value;

                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname_textbox.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_textbox.Text;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname_textbox.Text;
                command.Parameters.Add("@age", MySqlDbType.Date).Value = borndate_datepicker.Value;
                string sex = male_radiobutton.Checked ? "Мужской" : "Женский";
                command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;

                command.Parameters.Add("@faculty", MySqlDbType.Int32).Value = (int)facultyBox.SelectedValue;

                command.Parameters.Add("@spec", MySqlDbType.Int32).Value = (int)specialityBox.SelectedValue;
                command.Parameters.Add("@group", MySqlDbType.VarChar).Value = group_textbox.Text;

                string aducationform = offline_radiobutton.Checked ? "Очное" : "Заочное";
                command.Parameters.Add("@aducationform", MySqlDbType.VarChar).Value = aducationform;
                command.Parameters.Add("@startyear", MySqlDbType.VarChar).Value = startYearBox.Text;
                command.Parameters.Add("@endyear", MySqlDbType.VarChar).Value = endYearBox.Text;


                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Правки внесены");

                    this.Close();                   
                }
                else
                {
                    MessageBox.Show("Правки не внесены");
                }

                db.closeConnection();
            }
            else
            {
                int selectedYear = int.Parse(startYearBox.SelectedItem.ToString());


                command = new MySqlCommand("INSERT INTO students (surname, name, lastname, age, sex, faculty_id, speciality_id, groupnumber, aducation_form, start_year, end_year) VALUES (@surname,@name, @lastname, @age,@sex,@faculty, @spec, @group, @aducationform, @startyear, @endyear);", db.getConnection());

                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname_textbox.Text;
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_textbox.Text;
                command.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = lastname_textbox.Text;
                command.Parameters.Add("@age", MySqlDbType.Date).Value = borndate_datepicker.Value;
                string sex = male_radiobutton.Checked ? "Мужской" : "Женский";
                command.Parameters.Add("@sex", MySqlDbType.VarChar).Value = sex;

                command.Parameters.Add("@faculty", MySqlDbType.Int32).Value = (int)facultyBox.SelectedValue;

                command.Parameters.Add("@spec", MySqlDbType.Int32).Value = (int)specialityBox.SelectedValue;
                command.Parameters.Add("@group", MySqlDbType.VarChar).Value = group_textbox.Text;

                string aducationform = offline_radiobutton.Checked ? "Очное" : "Заочное";
                command.Parameters.Add("@aducationform", MySqlDbType.VarChar).Value = aducationform;
                command.Parameters.Add("@startyear", MySqlDbType.VarChar).Value = startYearBox.Text;
                command.Parameters.Add("@endyear", MySqlDbType.VarChar).Value = endYearBox.Text;
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
}
