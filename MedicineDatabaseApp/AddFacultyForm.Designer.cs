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
            facultyTextBox = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label_top = new Label();
            SuspendLayout();
            // 
            // facultyTextBox
            // 
            facultyTextBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            facultyTextBox.Location = new Point(330, 164);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(397, 26);
            facultyTextBox.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(69, 164);
            label4.Name = "label4";
            label4.Size = new Size(114, 27);
            label4.TabIndex = 49;
            label4.Text = "Факультет";
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 12F);
            button1.Location = new Point(69, 293);
            button1.Name = "button1";
            button1.Size = new Size(105, 38);
            button1.TabIndex = 53;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += backButtonClick;
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 12F);
            button2.Location = new Point(622, 293);
            button2.Name = "button2";
            button2.Size = new Size(105, 38);
            button2.TabIndex = 0;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Segoe UI", 20F);
            label_top.Location = new Point(250, 37);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(267, 37);
            label_top.TabIndex = 54;
            label_top.Text = "Добавить факультет";
            // 
            // AddFacultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(809, 457);
            Controls.Add(label_top);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Label label_top;
    }
}