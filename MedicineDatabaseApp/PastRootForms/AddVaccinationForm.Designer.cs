namespace MedicineDatabaseApp.PastRootForms
{
    partial class AddVaccinationForm
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
            back_to_main_button = new Button();
            button1 = new Button();
            typeTB = new TextBox();
            vaccine_date = new DateTimePicker();
            age_label = new Label();
            label1 = new Label();
            label2 = new Label();
            studentBox = new ComboBox();
            label3 = new Label();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // back_to_main_button
            // 
            back_to_main_button.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            back_to_main_button.Location = new Point(50, 324);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(123, 41);
            back_to_main_button.TabIndex = 37;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(571, 324);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 38;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // typeTB
            // 
            typeTB.Location = new Point(404, 169);
            typeTB.Margin = new Padding(4);
            typeTB.Name = "typeTB";
            typeTB.Size = new Size(229, 23);
            typeTB.TabIndex = 39;
            // 
            // vaccine_date
            // 
            vaccine_date.Location = new Point(404, 217);
            vaccine_date.Name = "vaccine_date";
            vaccine_date.Size = new Size(229, 23);
            vaccine_date.TabIndex = 40;
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            age_label.Location = new Point(116, 220);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(162, 24);
            age_label.TabIndex = 41;
            age_label.Text = "Дата прививки:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(116, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 24);
            label1.TabIndex = 42;
            label1.Text = "Тип прививки:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(116, 116);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(209, 24);
            label2.TabIndex = 43;
            label2.Text = "Выберите студента:";
            // 
            // studentBox
            // 
            studentBox.FormattingEnabled = true;
            studentBox.Location = new Point(404, 113);
            studentBox.Name = "studentBox";
            studentBox.Size = new Size(229, 23);
            studentBox.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(227, 30);
            label3.Name = "label3";
            label3.Size = new Size(318, 36);
            label3.TabIndex = 46;
            label3.Text = "Добавление прививки";
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(732, -2);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 40);
            closeAppBtn.TabIndex = 47;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // AddVaccinationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(766, 414);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(label3);
            Controls.Add(studentBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(age_label);
            Controls.Add(vaccine_date);
            Controls.Add(typeTB);
            Controls.Add(button1);
            Controls.Add(back_to_main_button);
            Name = "AddVaccinationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление прививки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button back_to_main_button;
        private Button button1;
        private TextBox typeTB;
        private DateTimePicker vaccine_date;
        private Label age_label;
        private Label label1;
        private Label label2;
        private ComboBox studentBox;
        private Label label3;
        private Button closeAppBtn;
    }
}