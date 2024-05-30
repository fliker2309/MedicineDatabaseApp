namespace MedicineDatabaseApp
{
    partial class AddSpecialityForm
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
            label_top = new Label();
            button2 = new Button();
            button1 = new Button();
            specialityTextBox = new TextBox();
            label4 = new Label();
            button3 = new Button();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label_top.Location = new Point(209, 30);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(405, 36);
            label_top.TabIndex = 59;
            label_top.Text = "Добавление специальности";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(646, 147);
            button2.Name = "button2";
            button2.Size = new Size(156, 53);
            button2.TabIndex = 55;
            button2.Text = "Добавить специальность";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(12, 379);
            button1.Name = "button1";
            button1.Size = new Size(105, 38);
            button1.TabIndex = 58;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // specialityTextBox
            // 
            specialityTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            specialityTextBox.Location = new Point(243, 157);
            specialityTextBox.Name = "specialityTextBox";
            specialityTextBox.Size = new Size(397, 29);
            specialityTextBox.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 162);
            label4.Name = "label4";
            label4.Size = new Size(213, 21);
            label4.TabIndex = 56;
            label4.Text = "Введите специальность:";
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(603, 339);
            button3.Name = "button3";
            button3.Size = new Size(184, 78);
            button3.TabIndex = 60;
            button3.Text = "Просмотреть список специальностей";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            closeAppBtn.TabIndex = 61;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // AddSpecialityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(808, 445);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(button3);
            Controls.Add(label_top);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(specialityTextBox);
            Controls.Add(label4);
            Name = "AddSpecialityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление специальности";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_top;
        private Button button2;
        private Button button1;
        private TextBox specialityTextBox;
        private Label label4;
        private Button button3;
        private Button closeAppBtn;
    }
}