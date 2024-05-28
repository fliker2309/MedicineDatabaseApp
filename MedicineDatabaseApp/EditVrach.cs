using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MedicineDatabaseApp
{
    public partial class EditVrachForm : Form
    {
        public EditVrachForm()
        {
            InitializeComponent();
            VrachlistView.MouseDoubleClick += EditVrachForm_MouseDoubleClick;
            this.Load += new EventHandler(Form_Load);
        }


        private void Form_Load(object? sender, EventArgs e)
        {
            VrachlistView.View = View.Details;
            VrachlistView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

            // Устанавливаем ширину каждой колонки
            VrachlistView.Columns.Add("Фамилия").Width = 150;
            VrachlistView.Columns.Add("Имя").Width = 150;
            VrachlistView.Columns.Add("Отчество").Width = 150;
            VrachlistView.Columns.Add("Дата Рождения").Width = 150;
            VrachlistView.Columns.Add("Должность").Width = 150;
            VrachlistView.Columns.Add("Квалификация").Width = 150;
            VrachlistView.Columns.Add("Стаж работы", -2, HorizontalAlignment.Left).Width = 100;

            LoadData();
        }
        private void EditVrachForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (VrachlistView.SelectedItems.Count > 0)
            {
                ListViewItem item = VrachlistView.SelectedItems[0];
                Vsurname_textbox.Text = item.SubItems[0].Text;
                VnameTB.Text = item.SubItems[1].Text;
                VlastnameTB.Text = item.SubItems[2].Text;
                Vborndate_datepicker.Text = item.SubItems[3].Text;
                VjobtitleTB.Text = item.SubItems[4].Text;
                VqualityTB.Text = item.SubItems[5].Text;
                VexpTimePicker.Text = item.SubItems[6].Text;
            }
        }
        private void LoadData()
        {
            VrachlistView.Items.Clear();
            string query = "SELECT id, surname, name, lastname, age, job_title, qualification, work_experience FROM doctors"; // теперь выбираем и id, и speciality

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
                    item.SubItems.Add(reader["age"].ToString());
                    item.SubItems.Add(reader["job_title"].ToString());
                    item.SubItems.Add(reader["qualification"].ToString());
                    item.SubItems.Add(reader["work_experience"].ToString());
                    item.Tag = reader["id"];
                    VrachlistView.Items.Add(item);
                }
            }
            db.closeConnection();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (VrachlistView.SelectedItems.Count > 0)
            {
                ListViewItem item = VrachlistView.SelectedItems[0];
                int surnameId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить врача?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteVrach(surnameId);
                    VrachlistView.Items.Remove(item);
                }
            }

        }
        private void DeleteVrach(int surnameId)
        {
            DB db = new DB();
            string deleteQuery = "DELETE FROM doctors WHERE id = @id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", surnameId);
            db.openConnection();
            deleteCommand.ExecuteNonQuery();
            db.closeConnection();
            Vsurname_textbox.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (VrachlistView.SelectedItems.Count > 0)
            {
                ListViewItem item = VrachlistView.SelectedItems[0];
                int idValue = (int)item.Tag; // Получаем id из свойства Tag выбранного элемента

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE doctors SET surname = @surname WHERE id = @id;", db.getConnection());
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Vsurname_textbox.Text;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idValue; // Используем полученное id
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (Vsurname_textbox.Text == "")
                    {
                        MessageBox.Show("Введите Фамилию");
                    }
                    else
                    {
                        MessageBox.Show("Врач изменен");
                        LoadData();

                    }
                    Vsurname_textbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите Фамилию");
                }

                db.closeConnection();
            }
        }
    }
}
