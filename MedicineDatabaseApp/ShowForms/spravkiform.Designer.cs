namespace MedicineDatabaseApp.ShowForms
{
    partial class spravkiform
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
            button1 = new Button();
            spravkiListView = new ListView();
            label1 = new Label();
            studentNameS = new Label();
            label2 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button4 = new Button();
            dateTimePicker1 = new DateTimePicker();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(12, 553);
            button1.Name = "button1";
            button1.Size = new Size(137, 45);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // spravkiListView
            // 
            spravkiListView.FullRowSelect = true;
            spravkiListView.Location = new Point(23, 86);
            spravkiListView.Name = "spravkiListView";
            spravkiListView.Size = new Size(924, 330);
            spravkiListView.TabIndex = 3;
            spravkiListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F);
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 31);
            label1.TabIndex = 2;
            label1.Text = "Список справок студента";
            label1.Click += label1_Click;
            // 
            // studentNameS
            // 
            studentNameS.Location = new Point(0, 0);
            studentNameS.Name = "studentNameS";
            studentNameS.Size = new Size(100, 23);
            studentNameS.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(328, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(548, 553);
            button2.Name = "button2";
            button2.Size = new Size(183, 45);
            button2.TabIndex = 5;
            button2.Text = "Удалить справку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(208, 490);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 7;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(581, 490);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(775, 490);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(172, 23);
            textBox5.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(389, 490);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 23);
            comboBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(775, 553);
            button3.Name = "button3";
            button3.Size = new Size(172, 45);
            button3.TabIndex = 13;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(25, 463);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 14;
            label3.Text = "Дата выдачи";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(242, 463);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 15;
            label4.Text = "Болезнь";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(437, 460);
            label5.Name = "label5";
            label5.Size = new Size(53, 22);
            label5.TabIndex = 16;
            label5.Text = "Врач";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(565, 460);
            label6.Name = "label6";
            label6.Size = new Size(183, 22);
            label6.TabIndex = 17;
            label6.Text = "Состояния здоровья";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label7.Location = new Point(808, 460);
            label7.Name = "label7";
            label7.Size = new Size(112, 22);
            label7.TabIndex = 18;
            label7.Text = "Заключение";
            // 
            // button4
            // 
            button4.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            button4.Location = new Point(328, 553);
            button4.Name = "button4";
            button4.Size = new Size(188, 45);
            button4.TabIndex = 19;
            button4.Text = "Добавить справку";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(23, 490);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(148, 23);
            dateTimePicker1.TabIndex = 20;
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(924, 0);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 21;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // spravkiform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(959, 610);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(dateTimePicker1);
            Controls.Add(button4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(studentNameS);
            Controls.Add(label1);
            Controls.Add(spravkiListView);
            Controls.Add(button1);
            Name = "spravkiform";
            Text = "Список справок студента";
            Load += spravkiform_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListView spravkiListView;
        private Label label1;
        private Label studentNameS;
        private Label label2;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox5;
        private ComboBox comboBox1;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button4;
        private DateTimePicker dateTimePicker1;
        private Button closeAppBtn;
    }
}