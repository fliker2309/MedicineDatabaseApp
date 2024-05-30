namespace MedicineDatabaseApp
{
    partial class AddCheckoutForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            back_to_main_button = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            textBox2 = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            closeAppBtn = new Button();
            textBox3 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(424, 116);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(244, 23);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(111, 117);
            label1.Name = "label1";
            label1.Size = new Size(189, 22);
            label1.TabIndex = 4;
            label1.Text = "Выберите студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(111, 175);
            label2.Name = "label2";
            label2.Size = new Size(290, 22);
            label2.TabIndex = 26;
            label2.Text = "Дата прохождения медосмотра";
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(605, 455);
            button1.Name = "button1";
            button1.Size = new Size(140, 48);
            button1.TabIndex = 29;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            back_to_main_button.Location = new Point(31, 455);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(133, 48);
            back_to_main_button.TabIndex = 28;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(424, 278);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 23);
            textBox1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(111, 279);
            label3.Name = "label3";
            label3.Size = new Size(155, 22);
            label3.TabIndex = 30;
            label3.Text = "Группа годности";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(111, 230);
            label4.Name = "label4";
            label4.Size = new Size(53, 22);
            label4.TabIndex = 32;
            label4.Text = "Врач";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(424, 229);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(244, 23);
            comboBox2.TabIndex = 33;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(424, 327);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 23);
            textBox2.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(111, 326);
            label5.Name = "label5";
            label5.Size = new Size(144, 22);
            label5.TabIndex = 35;
            label5.Text = "Годен / Не годен";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(424, 173);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(222, 28);
            label6.Name = "label6";
            label6.Size = new Size(362, 36);
            label6.TabIndex = 37;
            label6.Text = "Добавление медосмотра";
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(736, -3);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 38;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(425, 373);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 23);
            textBox3.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(118, 377);
            label7.Name = "label7";
            label7.Size = new Size(209, 22);
            label7.TabIndex = 40;
            label7.Text = "Причина прохождения";
            // 
            // AddCheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(773, 531);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(closeAppBtn);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(back_to_main_button);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "AddCheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCheckoutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button back_to_main_button;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
        private TextBox textBox2;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Button closeAppBtn;
        private TextBox textBox3;
        private Label label7;
    }
}