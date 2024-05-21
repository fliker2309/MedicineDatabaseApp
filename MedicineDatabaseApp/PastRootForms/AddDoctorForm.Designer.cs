namespace MedicineDatabaseApp.PastRootForms
{
    partial class AddDoctorForm
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
            lastname_label = new Label();
            age_label = new Label();
            faculcy_label = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            surname_textbox = new TextBox();
            nameTB = new TextBox();
            lastnameTB = new TextBox();
            jobtitleTB = new TextBox();
            qualityTB = new TextBox();
            label4 = new Label();
            borndate_datepicker = new DateTimePicker();
            expTimePicker = new DateTimePicker();
            back_to_main_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Segoe UI", 20F);
            label_top.Location = new Point(256, 20);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(217, 37);
            label_top.TabIndex = 20;
            label_top.Text = "Добавить врача";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Location = new Point(112, 167);
            lastname_label.Margin = new Padding(4, 0, 4, 0);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(58, 15);
            lastname_label.TabIndex = 22;
            lastname_label.Text = "Отчество";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Location = new Point(112, 202);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(90, 15);
            age_label.TabIndex = 23;
            age_label.Text = "Дата рождения";
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Location = new Point(112, 237);
            faculcy_label.Margin = new Padding(4, 0, 4, 0);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(69, 15);
            faculcy_label.TabIndex = 24;
            faculcy_label.Text = "Должность";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 273);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 25;
            label1.Text = "Квалификация";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 26;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 94);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 27;
            label3.Text = "Фамилия";
            // 
            // surname_textbox
            // 
            surname_textbox.Location = new Point(287, 94);
            surname_textbox.Margin = new Padding(4);
            surname_textbox.Name = "surname_textbox";
            surname_textbox.Size = new Size(229, 23);
            surname_textbox.TabIndex = 28;
            // 
            // nameTB
            // 
            nameTB.Location = new Point(287, 125);
            nameTB.Margin = new Padding(4);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(229, 23);
            nameTB.TabIndex = 29;
            // 
            // lastnameTB
            // 
            lastnameTB.Location = new Point(287, 156);
            lastnameTB.Margin = new Padding(4);
            lastnameTB.Name = "lastnameTB";
            lastnameTB.Size = new Size(229, 23);
            lastnameTB.TabIndex = 30;
            // 
            // jobtitleTB
            // 
            jobtitleTB.Location = new Point(287, 234);
            jobtitleTB.Margin = new Padding(4);
            jobtitleTB.Name = "jobtitleTB";
            jobtitleTB.Size = new Size(229, 23);
            jobtitleTB.TabIndex = 31;
            // 
            // qualityTB
            // 
            qualityTB.Location = new Point(287, 265);
            qualityTB.Margin = new Padding(4);
            qualityTB.Name = "qualityTB";
            qualityTB.Size = new Size(229, 23);
            qualityTB.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 309);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 33;
            label4.Text = "Стаж работы";
            label4.Click += label4_Click;
            // 
            // borndate_datepicker
            // 
            borndate_datepicker.Location = new Point(287, 194);
            borndate_datepicker.Name = "borndate_datepicker";
            borndate_datepicker.Size = new Size(229, 23);
            borndate_datepicker.TabIndex = 34;
            // 
            // expTimePicker
            // 
            expTimePicker.Location = new Point(287, 301);
            expTimePicker.Name = "expTimePicker";
            expTimePicker.Size = new Size(229, 23);
            expTimePicker.TabIndex = 35;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(112, 371);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(136, 41);
            back_to_main_button.TabIndex = 36;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(477, 371);
            button1.Name = "button1";
            button1.Size = new Size(136, 41);
            button1.TabIndex = 37;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddDoctorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(704, 450);
            Controls.Add(button1);
            Controls.Add(back_to_main_button);
            Controls.Add(expTimePicker);
            Controls.Add(borndate_datepicker);
            Controls.Add(label4);
            Controls.Add(qualityTB);
            Controls.Add(jobtitleTB);
            Controls.Add(lastnameTB);
            Controls.Add(nameTB);
            Controls.Add(surname_textbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(faculcy_label);
            Controls.Add(age_label);
            Controls.Add(lastname_label);
            Controls.Add(label_top);
            Name = "AddDoctorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDoctorForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label_top;
        private Label lastname_label;
        private Label age_label;
        private Label faculcy_label;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox surname_textbox;
        private TextBox nameTB;
        private TextBox lastnameTB;
        private TextBox jobtitleTB;
        private TextBox qualityTB;
        private Label label4;
        private DateTimePicker borndate_datepicker;
        private DateTimePicker expTimePicker;
        private Button back_to_main_button;
        private Button button1;
    }
}