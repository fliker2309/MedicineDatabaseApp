namespace MedicineDatabaseApp.ShowForms
{
    partial class ShowVaccinationForm
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
            vaccinationsListView = new ListView();
            label1 = new Label();
            backBtn = new Button();
            studentName = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // vaccinationsListView
            // 
            vaccinationsListView.FullRowSelect = true;
            vaccinationsListView.Location = new Point(12, 122);
            vaccinationsListView.Name = "vaccinationsListView";
            vaccinationsListView.Size = new Size(819, 278);
            vaccinationsListView.TabIndex = 0;
            vaccinationsListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(246, 23);
            label1.Name = "label1";
            label1.Size = new Size(319, 31);
            label1.TabIndex = 1;
            label1.Text = "Список прививок студента";
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            backBtn.Location = new Point(27, 526);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(197, 57);
            backBtn.TabIndex = 22;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            studentName.Location = new Point(246, 75);
            studentName.Name = "studentName";
            studentName.Size = new Size(59, 24);
            studentName.TabIndex = 23;
            studentName.Text = "ФИО";
            studentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(431, 458);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(220, 458);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 25;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(654, 526);
            button1.Name = "button1";
            button1.Size = new Size(168, 57);
            button1.TabIndex = 26;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(450, 526);
            button2.Name = "button2";
            button2.Size = new Size(175, 57);
            button2.TabIndex = 27;
            button2.Text = "Удалить прививку";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(246, 526);
            button3.Name = "button3";
            button3.Size = new Size(171, 57);
            button3.TabIndex = 28;
            button3.Text = "Добавить прививку";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(246, 422);
            label2.Name = "label2";
            label2.Size = new Size(144, 22);
            label2.TabIndex = 29;
            label2.Text = "Дата прививки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(467, 422);
            label3.Name = "label3";
            label3.Size = new Size(129, 22);
            label3.TabIndex = 30;
            label3.Text = "Тип прививки";
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(804, -1);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 31;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // ShowVaccinationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(843, 616);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(studentName);
            Controls.Add(backBtn);
            Controls.Add(label1);
            Controls.Add(vaccinationsListView);
            Name = "ShowVaccinationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список прививок студента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView vaccinationsListView;
        private Label label1;
        private Button backBtn;
        private Label studentName;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private Button closeAppBtn;
    }
}