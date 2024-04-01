
namespace MedicineDatabaseApp
{
    partial class AddInfoScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Label SurnameTV;
            Student_Surname = new TextBox();
            Student_Name = new TextBox();
            Student_LastName = new TextBox();
            ageText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ageTextView = new Label();
            SurnameTV = new Label();
            SuspendLayout();
            // 
            // SurnameTV
            // 
            SurnameTV.AutoSize = true;
            SurnameTV.Location = new Point(133, 68);
            SurnameTV.Name = "SurnameTV";
            SurnameTV.Size = new Size(58, 15);
            SurnameTV.TabIndex = 4;
            SurnameTV.Text = "Фамилия";
            // 
            // Student_Surname
            // 
            Student_Surname.Location = new Point(133, 86);
            Student_Surname.Name = "Student_Surname";
            Student_Surname.Size = new Size(100, 23);
            Student_Surname.TabIndex = 0;
            Student_Surname.KeyPress += Student_Name_KeyPress;
            // 
            // Student_Name
            // 
            Student_Name.Location = new Point(133, 137);
            Student_Name.Name = "Student_Name";
            Student_Name.Size = new Size(100, 23);
            Student_Name.TabIndex = 1;
            Student_Name.KeyPress += textBox2_KeyPress;
            // 
            // Student_LastName
            // 
            Student_LastName.Location = new Point(133, 192);
            Student_LastName.Name = "Student_LastName";
            Student_LastName.Size = new Size(100, 23);
            Student_LastName.TabIndex = 2;
            // 
            // ageText
            // 
            ageText.Location = new Point(133, 242);
            ageText.MaxLength = 3;
            ageText.Name = "ageText";
            ageText.Size = new Size(100, 23);
            ageText.TabIndex = 3;
            ageText.TextChanged += ageText_TextChanged;
            ageText.KeyPress += ageText_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 119);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 5;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 174);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 6;
            label3.Text = "Отчество";
            // 
            // ageTextView
            // 
            ageTextView.AutoSize = true;
            ageTextView.Location = new Point(133, 224);
            ageTextView.Name = "ageTextView";
            ageTextView.Size = new Size(50, 15);
            ageTextView.TabIndex = 7;
            ageTextView.Text = "Возраст";
            // 
            // AddInfoScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1078, 636);
            Controls.Add(ageTextView);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SurnameTV);
            Controls.Add(ageText);
            Controls.Add(Student_LastName);
            Controls.Add(Student_Name);
            Controls.Add(Student_Surname);
            Name = "AddInfoScreen";
            Text = "AddInfoScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Student_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox Student_Surname;
        private TextBox Student_Name;
        private TextBox Student_LastName;
        private TextBox ageText;
        private Label SurnameTV;
        private Label label2;
        private Label label3;
        private Label ageTextView;
    }
}