namespace MedicineDatabaseApp.PastRootForms
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
            addFacultyBtn = new Button();
            backBtn = new Button();
            editBtn = new Button();
            label_top = new Label();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // facultyTextBox
            // 
            facultyTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            facultyTextBox.Location = new Point(354, 105);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(403, 29);
            facultyTextBox.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 20.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(341, 31);
            label4.TabIndex = 51;
            label4.Text = "Введите новый факультет:";
            // 
            // addFacultyBtn
            // 
            addFacultyBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            addFacultyBtn.Location = new Point(769, 90);
            addFacultyBtn.Name = "addFacultyBtn";
            addFacultyBtn.Size = new Size(185, 58);
            addFacultyBtn.TabIndex = 53;
            addFacultyBtn.Text = "Добавить факультет";
            addFacultyBtn.UseVisualStyleBackColor = true;
            addFacultyBtn.Click += addFacultyBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            backBtn.Location = new Point(33, 365);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(114, 45);
            backBtn.TabIndex = 54;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            editBtn.Location = new Point(769, 355);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(155, 55);
            editBtn.TabIndex = 57;
            editBtn.Text = "Просмотр факультетов";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += EditBtn_Click;
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label_top.Location = new Point(303, 28);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(366, 36);
            label_top.TabIndex = 58;
            label_top.Text = "Добавления факультета";
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(931, -2);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 59;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // AddFacultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(966, 442);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(label_top);
            Controls.Add(editBtn);
            Controls.Add(backBtn);
            Controls.Add(addFacultyBtn);
            Controls.Add(facultyTextBox);
            Controls.Add(label4);
            Name = "AddFacultyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление факультета";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox facultyTextBox;
        private Label label4;
        private Button addFacultyBtn;
        private Button backBtn;
        private Button editBtn;
        private Label label_top;
        private Button closeAppBtn;
    }
}