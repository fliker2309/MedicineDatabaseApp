namespace MedicineDatabaseApp
{
    partial class AddForm
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
            surname_label = new Label();
            name_label = new Label();
            lastname_label = new Label();
            age_label = new Label();
            surname_textbox = new TextBox();
            name_textbox = new TextBox();
            lastname_textbox = new TextBox();
            age_textbox = new TextBox();
            label_sex = new Label();
            groupBox1 = new GroupBox();
            radio_button_female = new RadioButton();
            radio_button_male = new RadioButton();
            faculcy_label = new Label();
            faculty_textbox = new TextBox();
            group_label = new Label();
            spec_label = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            learning_form_label = new Label();
            groupBox2 = new GroupBox();
            online_radiobutton = new RadioButton();
            offline_radiobutton = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Location = new Point(327, 162);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(58, 15);
            surname_label.TabIndex = 0;
            surname_label.Text = "Фамилия";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(327, 207);
            name_label.Name = "name_label";
            name_label.Size = new Size(31, 15);
            name_label.TabIndex = 1;
            name_label.Text = "Имя";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Location = new Point(327, 249);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(58, 15);
            lastname_label.TabIndex = 2;
            lastname_label.Text = "Отчество";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Location = new Point(327, 288);
            age_label.Name = "age_label";
            age_label.Size = new Size(50, 15);
            age_label.TabIndex = 3;
            age_label.Text = "Возраст";
            // 
            // surname_textbox
            // 
            surname_textbox.Location = new Point(474, 159);
            surname_textbox.Name = "surname_textbox";
            surname_textbox.Size = new Size(179, 23);
            surname_textbox.TabIndex = 4;
            surname_textbox.KeyPress += surname_textbox_KeyPress;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(474, 199);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(179, 23);
            name_textbox.TabIndex = 5;
            name_textbox.KeyPress += name_textbox_KeyPress;
            // 
            // lastname_textbox
            // 
            lastname_textbox.Location = new Point(474, 241);
            lastname_textbox.Name = "lastname_textbox";
            lastname_textbox.Size = new Size(179, 23);
            lastname_textbox.TabIndex = 6;
            lastname_textbox.KeyPress += lastname_textbox_KeyPress;
            // 
            // age_textbox
            // 
            age_textbox.Location = new Point(474, 280);
            age_textbox.MaxLength = 3;
            age_textbox.Name = "age_textbox";
            age_textbox.Size = new Size(52, 23);
            age_textbox.TabIndex = 7;
            age_textbox.KeyPress += age_textbox_KeyPress;
            // 
            // label_sex
            // 
            label_sex.AutoSize = true;
            label_sex.Location = new Point(327, 369);
            label_sex.Name = "label_sex";
            label_sex.Size = new Size(30, 15);
            label_sex.TabIndex = 8;
            label_sex.Text = "Пол";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_button_female);
            groupBox1.Controls.Add(radio_button_male);
            groupBox1.Location = new Point(474, 309);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(100, 106);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // radio_button_female
            // 
            radio_button_female.AutoSize = true;
            radio_button_female.Location = new Point(13, 61);
            radio_button_female.Name = "radio_button_female";
            radio_button_female.Size = new Size(75, 19);
            radio_button_female.TabIndex = 1;
            radio_button_female.TabStop = true;
            radio_button_female.Text = "Женский";
            radio_button_female.UseVisualStyleBackColor = true;
            radio_button_female.CheckedChanged += radio_button_female_CheckedChanged;
            // 
            // radio_button_male
            // 
            radio_button_male.AutoSize = true;
            radio_button_male.Location = new Point(14, 22);
            radio_button_male.Name = "radio_button_male";
            radio_button_male.Size = new Size(77, 19);
            radio_button_male.TabIndex = 0;
            radio_button_male.TabStop = true;
            radio_button_male.Text = "Мужской";
            radio_button_male.UseVisualStyleBackColor = true;
            radio_button_male.CheckedChanged += radio_button_male_CheckedChanged;
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Location = new Point(327, 443);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(63, 15);
            faculcy_label.TabIndex = 11;
            faculcy_label.Text = "Факультет";
            // 
            // faculty_textbox
            // 
            faculty_textbox.Location = new Point(474, 435);
            faculty_textbox.Name = "faculty_textbox";
            faculty_textbox.Size = new Size(179, 23);
            faculty_textbox.TabIndex = 12;
            // 
            // group_label
            // 
            group_label.AutoSize = true;
            group_label.Location = new Point(327, 490);
            group_label.Name = "group_label";
            group_label.Size = new Size(46, 15);
            group_label.TabIndex = 13;
            group_label.Text = "Группа";
            // 
            // spec_label
            // 
            spec_label.AutoSize = true;
            spec_label.Location = new Point(327, 540);
            spec_label.Name = "spec_label";
            spec_label.Size = new Size(92, 15);
            spec_label.TabIndex = 14;
            spec_label.Text = "Специальность";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(474, 482);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 23);
            textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(474, 532);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 16;
            // 
            // learning_form_label
            // 
            learning_form_label.AutoSize = true;
            learning_form_label.Location = new Point(327, 609);
            learning_form_label.Name = "learning_form_label";
            learning_form_label.Size = new Size(101, 15);
            learning_form_label.TabIndex = 17;
            learning_form_label.Text = "Форма обучения";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(online_radiobutton);
            groupBox2.Controls.Add(offline_radiobutton);
            groupBox2.Location = new Point(474, 583);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(100, 106);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // online_radiobutton
            // 
            online_radiobutton.AutoSize = true;
            online_radiobutton.Location = new Point(13, 61);
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
            offline_radiobutton.Location = new Point(14, 22);
            offline_radiobutton.Name = "offline_radiobutton";
            offline_radiobutton.Size = new Size(60, 19);
            offline_radiobutton.TabIndex = 0;
            offline_radiobutton.TabStop = true;
            offline_radiobutton.Text = "Очная";
            offline_radiobutton.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1405, 873);
            Controls.Add(groupBox2);
            Controls.Add(learning_form_label);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(spec_label);
            Controls.Add(group_label);
            Controls.Add(faculty_textbox);
            Controls.Add(faculcy_label);
            Controls.Add(groupBox1);
            Controls.Add(label_sex);
            Controls.Add(age_textbox);
            Controls.Add(lastname_textbox);
            Controls.Add(name_textbox);
            Controls.Add(surname_textbox);
            Controls.Add(age_label);
            Controls.Add(lastname_label);
            Controls.Add(name_label);
            Controls.Add(surname_label);
            Name = "AddForm";
            Text = "AddForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label surname_label;
        private Label name_label;
        private Label lastname_label;
        private Label age_label;
        private TextBox surname_textbox;
        private TextBox name_textbox;
        private TextBox lastname_textbox;
        private TextBox age_textbox;
        private Label label_sex;
        private GroupBox groupBox1;
        private RadioButton radio_button_male;
        private RadioButton radio_button_female;
        private Label faculcy_label;
        private TextBox faculty_textbox;
        private Label group_label;
        private Label spec_label;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label learning_form_label;
        private GroupBox groupBox2;
        private RadioButton online_radiobutton;
        private RadioButton offline_radiobutton;
    }
}