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
            SuspendLayout();
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(116, 285);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(123, 41);
            back_to_main_button.TabIndex = 37;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(506, 285);
            button1.Name = "button1";
            button1.Size = new Size(127, 41);
            button1.TabIndex = 38;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // typeTB
            // 
            typeTB.Location = new Point(404, 117);
            typeTB.Margin = new Padding(4);
            typeTB.Name = "typeTB";
            typeTB.Size = new Size(229, 23);
            typeTB.TabIndex = 39;
            // 
            // vaccine_date
            // 
            vaccine_date.Location = new Point(404, 165);
            vaccine_date.Name = "vaccine_date";
            vaccine_date.Size = new Size(229, 23);
            vaccine_date.TabIndex = 40;
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            age_label.Location = new Point(116, 168);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(114, 20);
            age_label.TabIndex = 41;
            age_label.Text = "Дата прививки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(116, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 42;
            label1.Text = "Тип прививки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(116, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 43;
            label2.Text = "Ф.И.О. пациента";
            // 
            // studentBox
            // 
            studentBox.FormattingEnabled = true;
            studentBox.Location = new Point(404, 61);
            studentBox.Name = "studentBox";
            studentBox.Size = new Size(229, 23);
            studentBox.TabIndex = 45;
            // 
            // AddVaccinationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(766, 414);
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
            Text = "AddVaccinationForm";
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
    }
}