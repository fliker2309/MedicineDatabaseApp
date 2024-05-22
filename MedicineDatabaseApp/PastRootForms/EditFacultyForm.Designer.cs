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
            SuspendLayout();
            // 
            // facultyTextBox
            // 
            facultyTextBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            facultyTextBox.Location = new Point(330, 76);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(397, 26);
            facultyTextBox.TabIndex = 50;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(69, 76);
            label4.Name = "label4";
            label4.Size = new Size(114, 27);
            label4.TabIndex = 49;
            label4.Text = "Факультет";
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 12F);
            button1.Location = new Point(69, 372);
            button1.Name = "button1";
            button1.Size = new Size(105, 38);
            button1.TabIndex = 53;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += backButtonClick;
            // 
            // addFacultyBtn
            // 
            addFacultyBtn.Font = new Font("Trebuchet MS", 12F);
            addFacultyBtn.Location = new Point(622, 372);
            addFacultyBtn.Name = "addFacultyBtn";
            addFacultyBtn.Size = new Size(105, 38);
            addFacultyBtn.TabIndex = 0;
            addFacultyBtn.Text = "Сохранить";
            addFacultyBtn.UseVisualStyleBackColor = true;
            addFacultyBtn.Click += editBtn_Click;
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Segoe UI", 20F);
            label_top.Location = new Point(249, 18);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(381, 37);
            label_top.TabIndex = 54;
            label_top.Text = "Редактирование факультетов";
            // 
            // facultyForm
            // 
            facultyForm.Location = new Point(69, 141);
            facultyForm.Name = "facultyForm";
            facultyForm.Size = new Size(658, 170);
            facultyForm.TabIndex = 55;
            facultyForm.UseCompatibleStateImageBehavior = false;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            deleteBtn.Location = new Point(342, 372);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(105, 38);
            deleteBtn.TabIndex = 56;
            deleteBtn.Text = "Удалить";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += button3_Click;
            // 
            // EditFacultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(809, 444);
            Controls.Add(deleteBtn);
            Controls.Add(facultyForm);
            Controls.Add(label_top);
            Controls.Add(addFacultyBtn);
            Controls.Add(button1);
            Controls.Add(facultyTextBox);
            Controls.Add(label4);
            Name = "EditFacultyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditFacultyForm";
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
    }
}