namespace MedicineDatabaseApp
{
    partial class SearchForm
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
            maskedTextBox1 = new MaskedTextBox();
            back_to_main_button = new Button();
            searchBtn = new Button();
            label_top = new Label();
            groupBox2 = new GroupBox();
            online_radiobutton = new RadioButton();
            offline_radiobutton = new RadioButton();
            learning_form_label = new Label();
            spec_textbox = new TextBox();
            group_textbox = new TextBox();
            spec_label = new Label();
            group_label = new Label();
            faculty_textbox = new TextBox();
            faculcy_label = new Label();
            groupBox1 = new GroupBox();
            radio_button_female = new RadioButton();
            radio_button_male = new RadioButton();
            label_sex = new Label();
            lastname_textbox = new TextBox();
            name_textbox = new TextBox();
            age_label = new Label();
            lastname_label = new Label();
            name_label = new Label();
            surname_label = new Label();
            comboBox1 = new ComboBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(404, 326);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(90, 23);
            maskedTextBox1.TabIndex = 44;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(48, 869);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 43;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(629, 869);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(197, 57);
            searchBtn.TabIndex = 42;
            searchBtn.Text = "Поиск";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Segoe UI", 20F);
            label_top.Location = new Point(270, -104);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(341, 37);
            label_top.TabIndex = 41;
            label_top.Text = "Введите данные пациента";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(online_radiobutton);
            groupBox2.Controls.Add(offline_radiobutton);
            groupBox2.Location = new Point(404, 734);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(128, 148);
            groupBox2.TabIndex = 40;
            groupBox2.TabStop = false;
            // 
            // online_radiobutton
            // 
            online_radiobutton.AutoSize = true;
            online_radiobutton.Location = new Point(17, 87);
            online_radiobutton.Margin = new Padding(4);
            online_radiobutton.Name = "online_radiobutton";
            online_radiobutton.Size = new Size(71, 19);
            online_radiobutton.TabIndex = 1;
            online_radiobutton.TabStop = true;
            online_radiobutton.Text = "Заочная";
            online_radiobutton.UseVisualStyleBackColor = true;
            // 
            // offline_radiobutton
            // 
            offline_radiobutton.AutoSize = true;
            offline_radiobutton.Location = new Point(19, 32);
            offline_radiobutton.Margin = new Padding(4);
            offline_radiobutton.Name = "offline_radiobutton";
            offline_radiobutton.Size = new Size(60, 19);
            offline_radiobutton.TabIndex = 0;
            offline_radiobutton.TabStop = true;
            offline_radiobutton.Text = "Очная";
            offline_radiobutton.UseVisualStyleBackColor = true;
            // 
            // learning_form_label
            // 
            learning_form_label.AutoSize = true;
            learning_form_label.Location = new Point(204, 805);
            learning_form_label.Margin = new Padding(4, 0, 4, 0);
            learning_form_label.Name = "learning_form_label";
            learning_form_label.Size = new Size(101, 15);
            learning_form_label.TabIndex = 39;
            learning_form_label.Text = "Форма обучения";
            // 
            // spec_textbox
            // 
            spec_textbox.Location = new Point(404, 686);
            spec_textbox.Margin = new Padding(4);
            spec_textbox.Name = "spec_textbox";
            spec_textbox.Size = new Size(229, 23);
            spec_textbox.TabIndex = 38;
            // 
            // group_textbox
            // 
            group_textbox.Location = new Point(404, 614);
            group_textbox.Margin = new Padding(4);
            group_textbox.Name = "group_textbox";
            group_textbox.Size = new Size(229, 23);
            group_textbox.TabIndex = 37;
            // 
            // spec_label
            // 
            spec_label.AutoSize = true;
            spec_label.Location = new Point(213, 689);
            spec_label.Margin = new Padding(4, 0, 4, 0);
            spec_label.Name = "spec_label";
            spec_label.Size = new Size(92, 15);
            spec_label.TabIndex = 36;
            spec_label.Text = "Специальность";
            // 
            // group_label
            // 
            group_label.AutoSize = true;
            group_label.Location = new Point(215, 622);
            group_label.Margin = new Padding(4, 0, 4, 0);
            group_label.Name = "group_label";
            group_label.Size = new Size(46, 15);
            group_label.TabIndex = 35;
            group_label.Text = "Группа";
            // 
            // faculty_textbox
            // 
            faculty_textbox.Location = new Point(404, 555);
            faculty_textbox.Margin = new Padding(4);
            faculty_textbox.Name = "faculty_textbox";
            faculty_textbox.Size = new Size(229, 23);
            faculty_textbox.TabIndex = 34;
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Location = new Point(215, 563);
            faculcy_label.Margin = new Padding(4, 0, 4, 0);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(63, 15);
            faculcy_label.TabIndex = 33;
            faculcy_label.Text = "Факультет";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_button_female);
            groupBox1.Controls.Add(radio_button_male);
            groupBox1.Location = new Point(404, 362);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(128, 148);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // radio_button_female
            // 
            radio_button_female.AutoSize = true;
            radio_button_female.Location = new Point(17, 87);
            radio_button_female.Margin = new Padding(4);
            radio_button_female.Name = "radio_button_female";
            radio_button_female.Size = new Size(75, 19);
            radio_button_female.TabIndex = 1;
            radio_button_female.TabStop = true;
            radio_button_female.Text = "Женский";
            radio_button_female.UseVisualStyleBackColor = true;
            // 
            // radio_button_male
            // 
            radio_button_male.AutoSize = true;
            radio_button_male.Location = new Point(19, 32);
            radio_button_male.Margin = new Padding(4);
            radio_button_male.Name = "radio_button_male";
            radio_button_male.Size = new Size(77, 19);
            radio_button_male.TabIndex = 0;
            radio_button_male.TabStop = true;
            radio_button_male.Text = "Мужской";
            radio_button_male.UseVisualStyleBackColor = true;
            // 
            // label_sex
            // 
            label_sex.AutoSize = true;
            label_sex.Location = new Point(215, 495);
            label_sex.Margin = new Padding(4, 0, 4, 0);
            label_sex.Name = "label_sex";
            label_sex.Size = new Size(30, 15);
            label_sex.TabIndex = 31;
            label_sex.Text = "Пол";
            // 
            // lastname_textbox
            // 
            lastname_textbox.Location = new Point(404, 120);
            lastname_textbox.Margin = new Padding(4);
            lastname_textbox.Name = "lastname_textbox";
            lastname_textbox.Size = new Size(229, 23);
            lastname_textbox.TabIndex = 30;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(404, 64);
            name_textbox.Margin = new Padding(4);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(229, 23);
            name_textbox.TabIndex = 29;
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Location = new Point(215, 334);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(90, 15);
            age_label.TabIndex = 27;
            age_label.Text = "Дата рождения";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Location = new Point(215, 123);
            lastname_label.Margin = new Padding(4, 0, 4, 0);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(58, 15);
            lastname_label.TabIndex = 26;
            lastname_label.Text = "Отчество";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 12F);
            name_label.Location = new Point(215, 64);
            name_label.Margin = new Padding(4, 0, 4, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(41, 21);
            name_label.TabIndex = 25;
            name_label.Text = "Имя";
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Segoe UI", 12F);
            surname_label.Location = new Point(215, 0);
            surname_label.Margin = new Padding(4, 0, 4, 0);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(75, 21);
            surname_label.TabIndex = 24;
            surname_label.Text = "Фамилия";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(404, 34);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 45;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(922, 984);
            Controls.Add(comboBox1);
            Controls.Add(maskedTextBox1);
            Controls.Add(back_to_main_button);
            Controls.Add(searchBtn);
            Controls.Add(label_top);
            Controls.Add(groupBox2);
            Controls.Add(learning_form_label);
            Controls.Add(spec_textbox);
            Controls.Add(group_textbox);
            Controls.Add(spec_label);
            Controls.Add(group_label);
            Controls.Add(faculty_textbox);
            Controls.Add(faculcy_label);
            Controls.Add(groupBox1);
            Controls.Add(label_sex);
            Controls.Add(lastname_textbox);
            Controls.Add(name_textbox);
            Controls.Add(age_label);
            Controls.Add(lastname_label);
            Controls.Add(name_label);
            Controls.Add(surname_label);
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button back_to_main_button;
        private Button searchBtn;
        private Label label_top;
        private GroupBox groupBox2;
        private RadioButton online_radiobutton;
        private RadioButton offline_radiobutton;
        private Label learning_form_label;
        private TextBox spec_textbox;
        private TextBox group_textbox;
        private Label spec_label;
        private Label group_label;
        private TextBox faculty_textbox;
        private Label faculcy_label;
        private GroupBox groupBox1;
        private RadioButton radio_button_female;
        private RadioButton radio_button_male;
        private Label label_sex;
        private TextBox lastname_textbox;
        private TextBox name_textbox;
        private Label age_label;
        private Label lastname_label;
        private Label name_label;
        private Label surname_label;
        private ComboBox comboBox1;
    }
}