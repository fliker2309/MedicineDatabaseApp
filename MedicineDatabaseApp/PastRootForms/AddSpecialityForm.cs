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

namespace MedicineDatabaseApp
{
    public partial class AddSpecialityForm : Form
    {
        public AddSpecialityForm()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO specialities (speciality) VALUES (@speciality);", db.getConnection());
            command.Parameters.Add("@speciality", MySqlDbType.VarChar).Value = specialityTextBox.Text;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                if (specialityTextBox.Text == "")
                {
                    MessageBox.Show("Введите специальность");
                }
                else
                {
                    MessageBox.Show("Специальность добавлена");
                    this.Close();
                    PastRootForm rootForm = new PastRootForm();
                    rootForm.Show();
                }

            }
            else
            {
                MessageBox.Show("Введите специальность");
            }

            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PastRootForm rootForm = new PastRootForm();
            rootForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditSpecialityForm form = new EditSpecialityForm();
            form.ShowDialog();
            form.BringToFront();
        }
    }
}
