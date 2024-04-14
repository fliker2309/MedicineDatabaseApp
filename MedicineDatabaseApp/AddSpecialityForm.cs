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

        private void back_to_main_button_Click(object sender, EventArgs e)
        {

            this.Close();
            RootForm rootForm = new RootForm();
            rootForm.Show();
        }

        private void saveSpeciality_Click(object sender, EventArgs e)
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
                else {
                    MessageBox.Show("Специальность добавлена");
                    this.Close();
                    RootForm rootForm = new RootForm();
                    rootForm.Show();
                }             
                             
            }
            else
            {
                MessageBox.Show("Введите специальность");
            }

            db.closeConnection();
        }
    }
}
