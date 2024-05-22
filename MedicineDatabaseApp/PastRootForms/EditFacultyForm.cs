
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
    public partial class EditFacultyForm : Form
    {
        public EditFacultyForm()
        {
            InitializeComponent();
            facultyForm.MouseDoubleClick += facultyForm_MouseDoubleClick;
            this.Load += new EventHandler(Form_Load);
        }
        private void Form_Load(object? sender, EventArgs e)
        {
            facultyForm.View = View.Details;
            facultyForm.Columns.Add("Факультет", -2, HorizontalAlignment.Left);
            facultyForm.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            LoadData();
        }
        private void facultyForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(facultyForm.SelectedItems.Count > 0)
            {
                ListViewItem item = facultyForm.SelectedItems[0];
                facultyTextBox.Text = item.SubItems[0].Text;
            }
        }
        private void LoadData()
        {
            facultyForm.Items.Clear();
            string query = "SELECT id, faculty FROM faculties"; // теперь выбираем и id, и faculty

            DB db = new DB();

            MySqlCommand command = new MySqlCommand(query, db.getConnection());
            db.openConnection();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["faculty"].ToString());
                    item.Tag = reader["id"];
                    facultyForm.Items.Add(item);
                }
            }
            db.closeConnection();
        }
        private void backButtonClick(object sender, EventArgs e)
        {
            this.Close();           
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (facultyForm.SelectedItems.Count > 0)
            {
                ListViewItem item = facultyForm.SelectedItems[0];
                int idValue = (int)item.Tag; // Получаем id из свойства Tag выбранного элемента

                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE faculties SET faculty = @faculty WHERE id = @id;", db.getConnection());
                command.Parameters.Add("@faculty", MySqlDbType.VarChar).Value = facultyTextBox.Text;
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = idValue; // Используем полученное id
                db.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    if (facultyTextBox.Text == "")
                    {
                        MessageBox.Show("Введите факультет");
                    }
                    else
                    {
                        MessageBox.Show("Факультет изменен");
                        LoadData();
                        
                    }
                    facultyTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите факультет");
                }

                db.closeConnection();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if(facultyForm.SelectedItems.Count > 0)
            {
                ListViewItem item = facultyForm.SelectedItems[0];
                int facultyId = (int)item.Tag;

                DialogResult dialogResult = MessageBox.Show("Вы точно хотите удалить факультет?", "Подтверждение удаления", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteFaculty(facultyId);
                    facultyForm.Items.Remove(item);
                }
            }
        }
        private void DeleteFaculty(int facultyId)
        {
            DB db = new DB();
            string deleteQuery = "DELETE FROM faculties WHERE id = @id";
            MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, db.getConnection());
            deleteCommand.Parameters.AddWithValue("@id", facultyId);
            db.openConnection();
            deleteCommand.ExecuteNonQuery();
            db.closeConnection();
            facultyTextBox.Text = "";
        }
    }
}
