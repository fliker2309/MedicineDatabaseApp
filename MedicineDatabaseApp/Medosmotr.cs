using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicineDatabaseApp.ShowForms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MedicineDatabaseApp
{
    public partial class Medosmotr : Form
    {
        private int studentId;
        public Medosmotr(int studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            listViewmedosmotr.MouseDoubleClick += EditObrajForm_MouseDoubleClick;
            this.Load += new EventHandler(SpisokMedosmotrov_load);
            this.Load += new EventHandler(SpisokkMedosmotrovformForm_load);
        }
        private void EditObrajForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewmedosmotr.SelectedItems.Count > 0)
            {
                initialize_vrach();
                ListViewItem item = listViewmedosmotr.SelectedItems[0];
                dateTimePicker1.Text = item.SubItems[0].Text;
                comboBox1.Text = item.SubItems[1].Text;
                textBox1.Text = item.SubItems[2].Text;
                textBox2.Text = item.SubItems[3].Text;

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
        private void ResizeListViewColumns(System.Windows.Forms.ListView listView)
        {

            int totalColumnWidth = listView.Width - SystemInformation.VerticalScrollBarWidth;

            int columnWidth = totalColumnWidth / listView.Columns.Count;

            foreach (ColumnHeader column in listView.Columns)
            {
                column.Width = columnWidth;
            }
        }
        private void SpisokMedosmotrov_load(object sender, EventArgs e)
        {
            listViewmedosmotr.View = View.Details;
            listViewmedosmotr.Columns.Add("Дата медосмотра");
            listViewmedosmotr.Columns.Add("Врач");
            listViewmedosmotr.Columns.Add("Группа годности");
            listViewmedosmotr.Columns.Add("Годен / Не годен");
            listViewmedosmotr.Columns.Add("Причина прохождения");
            ResizeListViewColumns(listViewmedosmotr);

            string queryCardId = "SELECT card_id FROM medicalcards WHERE student_id = @studentId";
            string queryObraj = "SELECT body_check.*, CONCAT(doctors.surname, ' ', doctors.name, ' ', doctors.lastname) AS doctor_fullname FROM body_check JOIN doctors ON body_check.doctor_id = doctors.id WHERE card_id = @cardId";
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
                        DateTime ObrajDate = DateTime.Parse(reader["date_of_issue"].ToString());
                        string formattedDate = ObrajDate.ToString("dd.MM.yyyy");

                        ListViewItem item = new ListViewItem(formattedDate);
                        item.SubItems.Add(reader["doctor_fullname"].ToString());
                        item.SubItems.Add(reader["group_fizkult"].ToString());
                        item.SubItems.Add(reader["suitability"].ToString());
                        item.SubItems.Add(reader["prichina"].ToString());
                        item.Tag = reader["id"];
                        listViewmedosmotr.Items.Add(item);
                    }
                }
            }

            db.closeConnection();
        }
        private void SpisokkMedosmotrovformForm_load(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AddCheckoutForm form = new AddCheckoutForm();
            form.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewmedosmotr.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewmedosmotr.SelectedItems[0];
                int idValue = (int)item.Tag; // Получаем id из свойства Tag выбранного элемента

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE body_check SET date_of_issue = @date_of_issueR, doctor_id = @doctor_idR, group_fizkult = @group_fizkultR, suitability = @suitabilityR, prichina = @prichinaR WHERE id = @id;", db.getConnection());
                command.Parameters.Add("@date_of_issueR", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@doctor_idR", MySqlDbType.Int32).Value = (int)comboBox1.SelectedValue;
                command.Parameters.Add("@group_fizkultR", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@suitabilityR", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@prichinaR", MySqlDbType.VarChar).Value = textBox3.Text;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idValue; // Используем полученное id
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Введите Группу годности");
                    }
                    else
                    {
                        MessageBox.Show("Медосмотр изменен");
                        this.Close();
                    }
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите Годность");
                }

                db.closeConnection();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listViewmedosmotr.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewmedosmotr.SelectedItems[0];
                int surnameId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить справку", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteMedosmotd(surnameId);
                    listViewmedosmotr.Items.Remove(item);
                }
            }

        }
        private void DeleteMedosmotd(int surnameId)
        {
            DB db = new DB();
            string deleteQuery = "DELETE FROM body_check WHERE id = @id";
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


}
