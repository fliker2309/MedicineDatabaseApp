﻿namespace MedicineDatabaseApp.PastRootForms
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
            SuspendLayout();
            // 
            // facultyTextBox
            // 
            facultyTextBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            facultyTextBox.Location = new Point(330, 189);
            facultyTextBox.Name = "facultyTextBox";
            facultyTextBox.Size = new Size(397, 26);
            facultyTextBox.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(69, 189);
            label4.Name = "label4";
            label4.Size = new Size(114, 27);
            label4.TabIndex = 51;
            label4.Text = "Факультет";
            // 
            // addFacultyBtn
            // 
            addFacultyBtn.Font = new Font("Trebuchet MS", 12F);
            addFacultyBtn.Location = new Point(622, 365);
            addFacultyBtn.Name = "addFacultyBtn";
            addFacultyBtn.Size = new Size(105, 45);
            addFacultyBtn.TabIndex = 53;
            addFacultyBtn.Text = "Сохранить";
            addFacultyBtn.UseVisualStyleBackColor = true;
            addFacultyBtn.Click += addFacultyBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Trebuchet MS", 12F);
            backBtn.Location = new Point(69, 365);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(114, 45);
            backBtn.TabIndex = 54;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // editBtn
            // 
            editBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            editBtn.Location = new Point(330, 365);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(134, 45);
            editBtn.TabIndex = 57;
            editBtn.Text = "Редактирование";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += EditBtn_Click;
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Segoe UI", 20F);
            label_top.Location = new Point(271, 46);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(267, 37);
            label_top.TabIndex = 58;
            label_top.Text = "Добавить факультет";
            // 
            // AddFacultyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label_top);
            Controls.Add(editBtn);
            Controls.Add(backBtn);
            Controls.Add(addFacultyBtn);
            Controls.Add(facultyTextBox);
            Controls.Add(label4);
            Name = "AddFacultyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFacultyForm";
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
    }
}