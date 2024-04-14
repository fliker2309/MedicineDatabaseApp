namespace MedicineDatabaseApp
{
    partial class AddFacultyForm
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
            saveFaculty = new Button();
            back_to_main_button = new Button();
            facultyTextBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // saveFaculty
            // 
            saveFaculty.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveFaculty.Location = new Point(662, 772);
            saveFaculty.Name = "saveFaculty";
            saveFaculty.Size = new Size(197, 57);
            saveFaculty.TabIndex = 52;
            saveFaculty.Text = "Сохранить";
            saveFaculty.UseVisualStyleBackColor = true;
            saveFaculty.Click += saveFaculty_Click;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            back_to_main_button.Location = new Point(65, 772);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 51;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // facultyTextBox
            // 
            facultyTextBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            facultyTextBox.Location = new Point(462, 422);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(397, 26);
            facultyTextBox.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(65, 414);
            label4.Name = "label4";
            label4.Size = new Size(144, 35);
            label4.TabIndex = 49;
            label4.Text = "Факультет";
            // 
            // AddFacultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(895, 961);
            Controls.Add(saveFaculty);
            Controls.Add(back_to_main_button);
            Controls.Add(facultyTextBox);
            Controls.Add(label4);
            Name = "AddFacultyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFacultyForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveFaculty;
        private Button back_to_main_button;
        private TextBox facultyTextBox;
        private Label label4;
    }
}