using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicineDatabaseApp
{
    public partial class SearchForm : Form
    {

        public SearchForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(SearchForm_Load);

            initialize_specialities();
            initialize_faculties();
            initialize_groups();
            initialize_age();

            facultyBox.SelectedIndex = -1;
            specialityBox.SelectedIndex = -1;
            groupBox.SelectedIndex = -1;
            ageComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
            sexComboBox.SelectedIndex = -1;

            int startYear = 2020;
            int endYear = DateTime.Now.Year;

            for (int year = startYear; year <= endYear; year++)
            {
                yearComboBox.Items.Add(year.ToString());
            }
            sexComboBox.Items.AddRange(new object[] { "Мужской", "Женский" });
        }

        private void SearchForm_Load(object? sender, EventArgs e)
        {
            studentsListView.View = View.Details;

            studentsListView.Columns.Add("Фамилия");
            studentsListView.Columns.Add("Имя");
            studentsListView.Columns.Add("Отчество");
            studentsListView.Columns.Add("Пол");
            ResizeListViewColumns(studentsListView);

            LoadData();

          /*  string query = @"
SELECT students.*, faculties.faculty, specialities.speciality
FROM students
INNER JOIN faculties ON students.faculty_id = faculties.id
INNER JOIN specialities ON students.speciality_id = specialities.id
";

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["surname"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["lastname"].ToString());
                    item.SubItems.Add(reader["sex"].ToString());

                    item.Tag = reader["id"];

                    studentsListView.Items.Add(item);
                }
            }
            db.closeConnection();*/

            studentsListView.ItemActivate += (s, e) =>
            {
                if (studentsListView.SelectedItems.Count > 0)
                {
                    ListViewItem item = studentsListView.SelectedItems[0];

                    int studentId = (int)item.Tag;

                    StudentDetailsForm form = new StudentDetailsForm(studentId);
                    form.ShowDialog();
                    form.BringToFront();
                }
            };
        }

        private void LoadData()
        {
            studentsListView.Items.Clear();

            string query = @"
SELECT students.*, faculties.faculty, specialities.speciality
FROM students
INNER JOIN faculties ON students.faculty_id = faculties.id
INNER JOIN specialities ON students.speciality_id = specialities.id
";

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["surname"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["lastname"].ToString());
                    item.SubItems.Add(reader["sex"].ToString());

                    item.Tag = reader["id"];

                    studentsListView.Items.Add(item);
                }
            }
            db.closeConnection();
        }
        private void ResizeListViewColumns(System.Windows.Forms.ListView listView)
        {

            int totalColumnWidth = listView.Width - SystemInformation.VerticalScrollBarWidth;

            int columnWidth = totalColumnWidth / listView.Columns.Count;

            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void initialize_age()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT DATE_FORMAT(age, '%Y') as birthYear FROM students", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            List<string> ages = new List<string>();
            while (reader.Read())
            {
                ages.Add(reader.GetString(0));
            }
            ageComboBox.DataSource = ages;

            db.closeConnection();
        }

        private void initialize_groups()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT groupnumber FROM students", db.getConnection());
            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            List<string> groups = new List<string>();
            while (reader.Read())
            {
                groups.Add(reader.GetString(0));
            }
            groupBox.DataSource = groups;

            db.closeConnection();
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
        private void back_to_main_button_Click(object sender, EventArgs e)
        {
            this.Close();
            RootForm rootForm = new RootForm();
            rootForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string startYear = yearComboBox.Text;
            string speciality = specialityBox.Text;
            string dateOfBirth = ageComboBox.Text;
            string group = groupBox.Text;
            string faculty = facultyBox.Text;
            string sex = sexComboBox.Text;

            string query = @"
    SELECT students.*, faculties.faculty, specialities.speciality
    FROM students
    INNER JOIN faculties ON students.faculty_id = faculties.id
    INNER JOIN specialities ON students.speciality_id = specialities.id
    WHERE 1=1
";


            if (!string.IsNullOrEmpty(dateOfBirth))
            {
                query += " AND YEAR(age) = @dateOfBirth";
            }

            if (!string.IsNullOrEmpty(startYear))
            {
                query += " AND start_year = @start_year";
            }

            if (!string.IsNullOrEmpty(speciality))
            {
                query += " AND speciality = @speciality";
            }

            if (!string.IsNullOrEmpty(group))
            {
                query += " AND groupnumber = @group";
            }

            if (!string.IsNullOrEmpty(faculty))
            {
                query += " AND faculty = @faculty";
            }

            if (!string.IsNullOrEmpty(sex))
            {
                query += " AND sex = @sex";
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());

            if (!string.IsNullOrEmpty(dateOfBirth))
            {
                command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            }

            if (!string.IsNullOrEmpty(startYear))
            {
                command.Parameters.AddWithValue("@start_year", startYear);
            }

            if (!string.IsNullOrEmpty(speciality))
            {
                command.Parameters.AddWithValue("@speciality", speciality);
            }

            if (!string.IsNullOrEmpty(group))
            {
                command.Parameters.AddWithValue("@group", group);
            }

            if (!string.IsNullOrEmpty(faculty))
            {
                command.Parameters.AddWithValue("@faculty", faculty);
            }

            if (!string.IsNullOrEmpty(sex))
            {
                command.Parameters.AddWithValue("@sex", sex);
            }

            db.openConnection();

            studentsListView.Items.Clear();

            using (var reader = command.ExecuteReader())
            {
                bool hasRows = false;

                while (reader.Read())
                {
                    hasRows = true;
                    ListViewItem item = new ListViewItem(reader["surname"].ToString());
                    item.SubItems.Add(reader["name"].ToString());
                    item.SubItems.Add(reader["lastname"].ToString());
                    item.SubItems.Add(reader["sex"].ToString());

                    DateTime birthDate = Convert.ToDateTime(reader["age"]);
                    int age = DateTime.Now.Year - birthDate.Year;
                    if (birthDate > DateTime.Now.AddYears(-age)) age--;
                    item.SubItems.Add(age.ToString());
                    item.SubItems.Add(reader["faculty"].ToString());
                    item.SubItems.Add(reader["speciality"].ToString());
                    item.SubItems.Add(reader["groupnumber"].ToString());
                    item.SubItems.Add(reader["start_year"].ToString());

                    studentsListView.Items.Add(item);
                }
                if (!hasRows)
                {
                    ListViewItem item = new ListViewItem("Нет студентов");
                    studentsListView.Items.Add(item);
                }
            }

            db.closeConnection();
        }

        public void updateListView()
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            RootForm rootForm = new RootForm();
            rootForm.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (studentsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = studentsListView.SelectedItems[0];
                int studentId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить студента?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteStudent(studentId);
                    studentsListView.Items.Remove(item);
                }
            }
        }

        private void DeleteStudent(int studentId)
        {
            DB db = new DB();

            string deleteQuery = "DELETE FROM students WHERE id = @id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", studentId);
            db.openConnection();
            deleteCommand.ExecuteNonQuery();
            db.closeConnection();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (studentsListView.SelectedItems.Count > 0)
            {
                ListViewItem item = studentsListView.SelectedItems[0];
                int studentId = (int)item.Tag;

                AddStudentForm form = new AddStudentForm(studentId,this);
                form.ShowDialog();
                form.BringToFront();
            }
        }
    }
}
