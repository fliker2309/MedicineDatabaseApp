namespace MedicineDatabaseApp
{
    partial class Bolnicnie
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
            label2 = new Label();
            studentName = new Label();
            listViewbolnich = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(378, 19);
            label2.Name = "label2";
            label2.Size = new Size(291, 24);
            label2.TabIndex = 31;
            label2.Text = "Список больничных студента";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            studentName.Location = new Point(378, 55);
            studentName.Name = "studentName";
            studentName.Size = new Size(59, 24);
            studentName.TabIndex = 30;
            studentName.Text = "ФИО";
            studentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewbolnich
            // 
            listViewbolnich.FullRowSelect = true;
            listViewbolnich.Location = new Point(12, 96);
            listViewbolnich.Name = "listViewbolnich";
            listViewbolnich.Size = new Size(945, 248);
            listViewbolnich.TabIndex = 32;
            listViewbolnich.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(12, 515);
            button1.Name = "button1";
            button1.Size = new Size(112, 38);
            button1.TabIndex = 33;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(394, 437);
            button2.Name = "button2";
            button2.Size = new Size(160, 37);
            button2.TabIndex = 34;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(394, 510);
            button3.Name = "button3";
            button3.Size = new Size(160, 40);
            button3.TabIndex = 35;
            button3.Text = "Удалить запись";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button4.Location = new Point(819, 490);
            button4.Name = "button4";
            button4.Size = new Size(127, 61);
            button4.TabIndex = 36;
            button4.Text = "Добавить больничный";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(379, 386);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 23);
            textBox1.TabIndex = 37;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(479, 386);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(277, 23);
            textBox2.TabIndex = 38;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 386);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(180, 23);
            dateTimePicker1.TabIndex = 39;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(198, 386);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(175, 23);
            dateTimePicker2.TabIndex = 40;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(762, 386);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(60, 362);
            label1.Name = "label1";
            label1.Size = new Size(76, 22);
            label1.TabIndex = 42;
            label1.Text = "С даты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(236, 361);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 43;
            label3.Text = "По дату";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(394, 359);
            label4.Name = "label4";
            label4.Size = new Size(64, 22);
            label4.TabIndex = 44;
            label4.Text = "Номер";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(579, 359);
            label5.Name = "label5";
            label5.Size = new Size(76, 22);
            label5.TabIndex = 45;
            label5.Text = "Болезнь";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(830, 359);
            label6.Name = "label6";
            label6.Size = new Size(53, 22);
            label6.TabIndex = 46;
            label6.Text = "Врач";
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(932, -6);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 47;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // Bolnicnie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(969, 565);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listViewbolnich);
            Controls.Add(label2);
            Controls.Add(studentName);
            Name = "Bolnicnie";
            Text = "Больничные студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label studentName;
        private ListView listViewbolnich;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button closeAppBtn;
    }
}