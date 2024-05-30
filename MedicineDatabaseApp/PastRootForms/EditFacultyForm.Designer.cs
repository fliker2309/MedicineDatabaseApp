namespace MedicineDatabaseApp
{
    partial class EditFacultyForm
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
            addFacultyBtn = new Button();
            label_top = new Label();
            facultyForm = new ListView();
            deleteBtn = new Button();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // facultyTextBox
            // 
            facultyTextBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            facultyTextBox.Location = new Point(261, 86);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(466, 26);
            facultyTextBox.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(69, 76);
            label4.Name = "label4";
            label4.Size = new Size(199, 36);
            label4.TabIndex = 49;
            label4.Text = "Факультет: ";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(69, 370);
            button1.Name = "button1";
            button1.Size = new Size(105, 38);
            button1.TabIndex = 53;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += backButtonClick;
            // 
            // addFacultyBtn
            // 
            addFacultyBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            addFacultyBtn.Location = new Point(585, 370);
            addFacultyBtn.Name = "addFacultyBtn";
            addFacultyBtn.Size = new Size(142, 38);
            addFacultyBtn.TabIndex = 0;
            addFacultyBtn.Text = "Сохранить";
            addFacultyBtn.UseVisualStyleBackColor = true;
            addFacultyBtn.Click += editBtn_Click;
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label_top.Location = new Point(107, 22);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(608, 36);
            label_top.TabIndex = 54;
            label_top.Text = "Редактирование и удаление факультетов";
            // 
            // facultyForm
            // 
            facultyForm.Location = new Point(69, 118);
            facultyForm.Name = "facultyForm";
            facultyForm.Size = new Size(669, 246);
            facultyForm.TabIndex = 55;
            facultyForm.UseCompatibleStateImageBehavior = false;
            facultyForm.SelectedIndexChanged += facultyForm_SelectedIndexChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            deleteBtn.ForeColor = Color.Red;
            deleteBtn.Location = new Point(310, 370);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(175, 60);
            deleteBtn.TabIndex = 56;
            deleteBtn.Text = "Удалить факультет";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += button3_Click;
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(774, -3);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 57;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // EditFacultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(809, 444);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(deleteBtn);
            Controls.Add(facultyForm);
            Controls.Add(label_top);
            Controls.Add(addFacultyBtn);
            Controls.Add(button1);
            Controls.Add(facultyTextBox);
            Controls.Add(label4);
            Name = "EditFacultyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование факультетов";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveFaculty;
        private Button back_to_main_button;
        private TextBox facultyTextBox;
        private Label label4;
        private Button button1;
        private Button addFacultyBtn;
        private Label label_top;
        private ListView facultyForm;
        private Button deleteBtn;
        private Button closeAppBtn;
    }
}