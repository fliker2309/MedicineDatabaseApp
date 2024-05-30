namespace MedicineDatabaseApp
{
    partial class AddCertificateForm
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
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            back_to_main_button = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            label7 = new Label();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(55, 252);
            label4.Name = "label4";
            label4.Size = new Size(53, 22);
            label4.TabIndex = 52;
            label4.Text = "Врач";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 23);
            textBox1.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(55, 205);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 50;
            label3.Text = "Болезнь";
            label3.Click += label3_Click;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            back_to_main_button.Location = new Point(23, 481);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 48;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(55, 156);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 46;
            label2.Text = "Дата выдачи";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(55, 104);
            label1.Name = "label1";
            label1.Size = new Size(189, 22);
            label1.TabIndex = 44;
            label1.Text = "Выберите студента";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(266, 307);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(305, 23);
            textBox3.TabIndex = 54;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(266, 381);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(305, 23);
            textBox4.TabIndex = 55;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(55, 308);
            label5.Name = "label5";
            label5.Size = new Size(181, 22);
            label5.TabIndex = 56;
            label5.Text = "Состояние здоровья";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(55, 369);
            label6.Name = "label6";
            label6.Size = new Size(112, 22);
            label6.TabIndex = 57;
            label6.Text = "Заключение";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(266, 154);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(305, 23);
            dateTimePicker1.TabIndex = 58;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(266, 253);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(305, 23);
            comboBox1.TabIndex = 59;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(266, 105);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(305, 23);
            comboBox2.TabIndex = 60;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(406, 481);
            button2.Name = "button2";
            button2.Size = new Size(191, 57);
            button2.TabIndex = 61;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.Location = new Point(183, 25);
            label7.Name = "label7";
            label7.Size = new Size(298, 36);
            label7.TabIndex = 62;
            label7.Text = "Добавление справки";
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(612, 0);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 63;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // AddCertificateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(648, 583);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(back_to_main_button);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddCertificateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление справки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button back_to_main_button;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private Label label7;
        private Button closeAppBtn;
    }
}