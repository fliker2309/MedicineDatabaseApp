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
    public partial class EditSpecialityForm : Form
    {
        public EditSpecialityForm()
        {
            InitializeComponent();
            SpecialityForm.MouseDoubleClick += SpecialityForm_MouseDoubleClick;
            this.Load += new EventHandler(Form_Load);
        }

        private void Form_Load(object? sender, EventArgs e)
        {
            SpecialityForm.View = View.Details;
            SpecialityForm.Columns.Add("Специальность", -2, HorizontalAlignment.Left);
            SpecialityForm.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            LoadData();
        }
        private void SpecialityForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (SpecialityForm.SelectedItems.Count > 0)
            {
                ListViewItem item = SpecialityForm.SelectedItems[0];
                SpecialityTextBox.Text = item.SubItems[0].Text;
            }
        }
        private void LoadData()
        {
            SpecialityForm.Items.Clear();
            string query = "SELECT id, speciality FROM specialities"; // теперь выбираем и id, и speciality

            DB db = new DB();

            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["speciality"].ToString());
                    item.Tag = reader["id"];
                    SpecialityForm.Items.Add(item);
                }
            }
            db.closeConnection();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if (SpecialityForm.SelectedItems.Count > 0)
            {
                ListViewItem item = SpecialityForm.SelectedItems[0];
                int idValue = (int)item.Tag; // Получаем id из свойства Tag выбранного элемента

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE speciality SET speciality = @speciality WHERE id = @id;", db.getConnection());
                command.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = SpecialityTextBox.Text;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idValue; // Используем полученное id
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (SpecialityTextBox.Text == "")
                    {
                        MessageBox.Show("Введите специальность");
                    }
                    else
                    {
                        MessageBox.Show("Специальность изменена");
                        LoadData();

                    }
                    SpecialityTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите специальность");
                }

                db.closeConnection();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SpecialityForm.SelectedItems.Count > 0)
            {
                ListViewItem item = SpecialityForm.SelectedItems[0];
                int specialityId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить факультет?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteSpeciality(specialityId);
                    SpecialityForm.Items.Remove(item);
                }
            }
        }
        private void DeleteSpeciality(int specialityId)
        {
            DB db = new DB();
            string deleteQuery = "DELETE FROM specialities WHERE id = @id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", specialityId);
            db.openConnection();
            deleteCommand.ExecuteNonQuery();
            db.closeConnection();
            SpecialityTextBox.Text = "";
        }
    }
}
