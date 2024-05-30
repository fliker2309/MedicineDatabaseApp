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
using MySql.Data.MySqlClient;

namespace MedicineDatabaseApp
{
    public partial class Bolnicnie : Form
    {
        private int studentId;
        public Bolnicnie(int studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
            listViewbolnich.MouseDoubleClick += EditBolnichForm_MouseDoubleClick;
            this.Load += new EventHandler(SpisokBolnicnih_load);
            this.Load += new EventHandler(SpisokkBolnicnihformForm_load);
        }
        private void EditBolnichForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listViewbolnich.SelectedItems.Count > 0)
            {
                initialize_vrach();
                ListViewItem item = listViewbolnich.SelectedItems[0];
                dateTimePicker1.Text = item.SubItems[0].Text;
                dateTimePicker2.Text = item.SubItems[1].Text;
                textBox1.Text = item.SubItems[2].Text;
                textBox2.Text = item.SubItems[3].Text;
                comboBox1.Text = item.SubItems[4].Text;

            }
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

        private void SpisokBolnicnih_load(object sender, EventArgs e)
        {
            listViewbolnich.View = View.Details;
            listViewbolnich.Columns.Add("С даты");
            listViewbolnich.Columns.Add("По дату");
            listViewbolnich.Columns.Add("Номер");
            listViewbolnich.Columns.Add("Болезнь");
            listViewbolnich.Columns.Add("Врач");
            ResizeListViewColumns(listViewbolnich);

            string queryCardId = "SELECT card_id FROM medicalcards WHERE student_id = @studentId";
            string queryObraj = "SELECT sick_leave.*, CONCAT(doctors.surname, ' ', doctors.name, ' ', doctors.lastname) AS doctor_fullname FROM sick_leave JOIN doctors ON sick_leave.doctor_id = doctors.id WHERE card_id = @cardId";
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
                        DateTime ObrajDate1 = DateTime.Parse(reader["sick_start"].ToString());
                        DateTime ObrajDate2 = DateTime.Parse(reader["sick_end"].ToString());
                        string formattedDate1 = ObrajDate1.ToString("dd.MM.yyyy");
                        string formattedDate2 = ObrajDate2.ToString("dd.MM.yyyy");

                        ListViewItem item = new ListViewItem(formattedDate1);
                        item.SubItems.Add(formattedDate2);
                        item.SubItems.Add(reader["sick_number"].ToString());
                        item.SubItems.Add(reader["sick_type"].ToString());
                        item.SubItems.Add(reader["doctor_fullname"].ToString());
                        item.Tag = reader["id"];
                        listViewbolnich.Items.Add(item);
                    }
                }
            }

            db.closeConnection();
        }
        private void SpisokkBolnicnihformForm_load(object sender, EventArgs e)
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
        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewbolnich.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewbolnich.SelectedItems[0];
                int idValue = (int)item.Tag; // Получаем id из свойства Tag выбранного элемента

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE sick_leave SET sick_number = @sick_numberR, sick_type = @sick_typeR, sick_start = @sick_startR, sick_end = @sick_endR, doctor_id = @doctor_idR WHERE id = @id;", db.getConnection());
                command.Parameters.Add("@sick_numberR", MySqlDbType.VarChar).Value = textBox1.Text;
                command.Parameters.Add("@sick_typeR", MySqlDbType.VarChar).Value = textBox2.Text;
                command.Parameters.Add("@sick_startR", MySqlDbType.Date).Value = dateTimePicker1.Value;
                command.Parameters.Add("@sick_endR", MySqlDbType.Date).Value = dateTimePicker2.Value;
                command.Parameters.Add("@doctor_idR", MySqlDbType.Int32).Value = (int)comboBox1.SelectedValue;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idValue; // Используем полученное id
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (textBox1.Text == "")
                    {
                        MessageBox.Show("Введите номер");
                    }
                    else
                    {
                        MessageBox.Show("Больничный изменен");
                        this.Close();
                    }
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите болезнь");
                }

                db.closeConnection();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listViewbolnich.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewbolnich.SelectedItems[0];
                int surnameId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить справку", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteBolnichniy(surnameId);
                    listViewbolnich.Items.Remove(item);
                }
            }
        }
        private void DeleteBolnichniy(int surnameId)
        {
            DB db = new DB();
            string deleteQuery = "DELETE FROM sick_leave WHERE id = @id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", surnameId);
            db.openConnection();
            deleteCommand.ExecuteNonQuery();
            db.closeConnection();
            dateTimePicker1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            BolnicnieADD form = new BolnicnieADD();
            form.ShowDialog();

        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
