using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicineDatabaseApp
{
    public partial class Spisokspravok : Form
    {
        private int studentId;
        private int cardId;
        public Spisokspravok(int studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            listViewobraj.MouseDoubleClick += EditObrajForm_MouseDoubleClick;
            this.Load += new EventHandler(Spisokspravok_load);
            this.Load += new EventHandler(SpisokspravokformForm_load);
        }
        private void EditObrajForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewobraj.SelectedItems.Count > 0)
            {
                initialize_vrach();
                ListViewItem item = listViewobraj.SelectedItems[0];
                dateTimePicker1.Text = item.SubItems[0].Text;
                textBox1.Text = item.SubItems[1].Text;
                textBox2.Text = item.SubItems[2].Text;
                textBox3.Text = item.SubItems[3].Text;
                textBox4.Text = item.SubItems[4].Text;
                textBox5.Text = item.SubItems[5].Text;
                textBox6.Text = item.SubItems[6].Text;
                comboBox1.Text = item.SubItems[7].Text;
                textBox7.Text = item.SubItems[8].Text;


            }
        }
        private void initialize_vrach()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("SELECT id, CONCAT(surname, ' ', name, ' ', lastname) AS fullname FROM doctors", db.getConnection());

            db.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            DataTable surname = new DataTable();
            surname.Load(reader);
            comboBox1.DataSource = surname;
            comboBox1.DisplayMember = "fullname";
            comboBox1.ValueMember = "id";

            db.closeConnection();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Spisokspravok_load(object sender, EventArgs e)
        {
            listViewobraj.View = View.Details;
            listViewobraj.Columns.Add("Дата обращения");
            listViewobraj.Columns.Add("Жалобы");
            listViewobraj.Columns.Add("Симптомы");
            listViewobraj.Columns.Add("Температура тела");
            listViewobraj.Columns.Add("Давление");
            listViewobraj.Columns.Add("Диагноз");
            listViewobraj.Columns.Add("Рекомендации");
            listViewobraj.Columns.Add("Врач");
            listViewobraj.Columns.Add("Хирургическая операция");
            ResizeListViewColumns(listViewobraj);

            string queryCardId = "SELECT card_id FROM medicalcards WHERE student_id = @studentId";
            string queryObraj = "SELECT health_visits.*, CONCAT(doctors.surname, ' ', doctors.name, ' ', doctors.lastname) AS doctor_fullname FROM health_visits JOIN doctors ON health_visits.doctor_id = doctors.id WHERE card_id = @cardId";
            DB db = new DB();
            MySqlCommand command = new MySqlCommand(queryCardId, db.getConnection());
            command.Parameters.AddWithValue("@studentId", studentId);

            db.openConnection();
            int cardId = 0;

            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    cardId = int.Parse(reader["card_id"].ToString());
                }
            }

            if (cardId > 0)
            {
                command.CommandText = queryObraj;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@cardId", cardId);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime ObrajDate = DateTime.Parse(reader["visit_date"].ToString());
                        string formattedDate = ObrajDate.ToString("dd.MM.yyyy");

                        ListViewItem item = new ListViewItem(formattedDate);
                        item.SubItems.Add(reader["complaints"].ToString());
                        item.SubItems.Add(reader["symptoms"].ToString());
                        item.SubItems.Add(reader["body_temperature"].ToString());
                        item.SubItems.Add(reader["body_pressure"].ToString());
                        item.SubItems.Add(reader["diagnos"].ToString());
                        item.SubItems.Add(reader["recommendations"].ToString());
                        item.SubItems.Add(reader["doctor_fullname"].ToString());
                        item.SubItems.Add(reader["surgical_intervention"].ToString());
                        item.Tag = reader["id"];
                        listViewobraj.Items.Add(item);
                    }
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

        private void SpisokspravokformForm_load(object sender, EventArgs e)
        {
            string query = @"
            SELECT  
            CONCAT(surname, ' ', name, ' ', lastname) 
            AS FullName 
            FROM students
            WHERE students.id = @id";

            DB db = new DB();
            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            command.Parameters.AddWithValue("@id", studentId);
            db.openConnection();
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    studentName.Text = reader["FullName"].ToString();
                }
            }
            db.closeConnection();
        }
        private void studentName_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewobraj.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewobraj.SelectedItems[0];
                int idValue = (int)item.Tag; // Получаем id из свойства Tag выбранного элемента

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE health_visits SET complaints = @complaintsR, symptoms = @symptomsR, body_temperature = @body_temperatureR, body_pressure = @body_pressureR, diagnos = @diagnosR, recommendations = @recommendationsR, doctor_id = @doctor_idR, visit_date = @visit_dateR, surgical_intervention = @surgical_interventionR WHERE id = @id;", db.getConnection());

                command.Parameters.Add("@complaintsR", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@symptomsR", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@body_temperatureR", MySqlDbType.VarChar).Value = textBox3.Text;
                command.Parameters.Add("@body_pressureR", MySqlDbType.VarChar).Value = textBox4.Text;
                command.Parameters.Add("@diagnosR", MySqlDbType.VarChar).Value = textBox5.Text;
                command.Parameters.Add("@recommendationsR", MySqlDbType.VarChar).Value = textBox6.Text;
                command.Parameters.Add("@doctor_idR", MySqlDbType.Int32).Value = (int)comboBox1.SelectedValue;
                command.Parameters.Add("@visit_dateR", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@surgical_interventionR", MySqlDbType.VarChar).Value = textBox7.Text;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idValue; // Используем полученное id
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Введите Жалобы");
                    }
                    else
                    {
                        MessageBox.Show("Справка изменена");
                        this.Close();
                    }
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите Симптомы");
                }

                db.closeConnection();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Obrvmedpunkt form = new Obrvmedpunkt();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewobraj.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewobraj.SelectedItems[0];
                int surnameId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить справку", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteObraj(surnameId);
                    listViewobraj.Items.Remove(item);
                }
            }
        }
        private void DeleteObraj(int surnameId)
        {
            DB db = new DB();
            string deleteQuery = "DELETE FROM health_visits WHERE id = @id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", surnameId);
            db.openConnection();
            deleteCommand.ExecuteNonQuery();
            db.closeConnection();
            dateTimePicker1.Text = "";
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
