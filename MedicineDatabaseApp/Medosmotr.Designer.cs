namespace MedicineDatabaseApp
{
    partial class Medosmotr
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
            listViewmedosmotr = new ListView();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            closeAppBtn = new Button();
            textBox3 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(334, 9);
            label2.Name = "label2";
            label2.Size = new Size(284, 24);
            label2.TabIndex = 29;
            label2.Text = "Список медосотров студента";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            studentName.Location = new Point(334, 49);
            studentName.Name = "studentName";
            studentName.Size = new Size(59, 24);
            studentName.TabIndex = 28;
            studentName.Text = "ФИО";
            studentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listViewmedosmotr
            // 
            listViewmedosmotr.FullRowSelect = true;
            listViewmedosmotr.Location = new Point(12, 85);
            listViewmedosmotr.Name = "listViewmedosmotr";
            listViewmedosmotr.Size = new Size(903, 219);
            listViewmedosmotr.TabIndex = 30;
            listViewmedosmotr.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(12, 485);
            button1.Name = "button1";
            button1.Size = new Size(109, 43);
            button1.TabIndex = 31;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 356);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(153, 23);
            dateTimePicker1.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(180, 356);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 23);
            comboBox1.TabIndex = 33;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 356);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(159, 23);
            textBox1.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(546, 356);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 35;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(752, 480);
            button2.Name = "button2";
            button2.Size = new Size(162, 52);
            button2.TabIndex = 36;
            button2.Text = "Добавить медосмотр";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(12, 329);
            label1.Name = "label1";
            label1.Size = new Size(169, 22);
            label1.TabIndex = 37;
            label1.Text = "Дата медосмотра";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(250, 331);
            label3.Name = "label3";
            label3.Size = new Size(53, 22);
            label3.TabIndex = 38;
            label3.Text = "Врач";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(385, 329);
            label4.Name = "label4";
            label4.Size = new Size(155, 22);
            label4.TabIndex = 39;
            label4.Text = "Группа годности";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(546, 329);
            label5.Name = "label5";
            label5.Size = new Size(144, 22);
            label5.TabIndex = 40;
            label5.Text = "Годен / Не годен";
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(385, 404);
            button3.Name = "button3";
            button3.Size = new Size(162, 41);
            button3.TabIndex = 41;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(385, 467);
            button4.Name = "button4";
            button4.Size = new Size(162, 41);
            button4.TabIndex = 42;
            button4.Text = "Удалить запись";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(890, -7);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 43;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(696, 356);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 44;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(696, 329);
            label6.Name = "label6";
            label6.Size = new Size(209, 22);
            label6.TabIndex = 45;
            label6.Text = "Причина прохождения";
            // 
            // Medosmotr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(926, 553);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(closeAppBtn);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(listViewmedosmotr);
            Controls.Add(label2);
            Controls.Add(studentName);
            Name = "Medosmotr";
            Text = "Медосмотры студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label studentName;
        private ListView listViewmedosmotr;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
        private Button button4;
        private Button closeAppBtn;
        private TextBox textBox3;
        private Label label6;
    }
}