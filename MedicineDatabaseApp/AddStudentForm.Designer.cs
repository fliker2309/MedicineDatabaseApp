namespace MedicineDatabaseApp
{
    partial class AddStudentForm
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
            label_sex = new Label();
            groupBox1 = new GroupBox();
            radio_button_female = new RadioButton();
            radio_button_male = new RadioButton();
            faculcy_label = new Label();
            faculty_textbox = new TextBox();
            group_label = new Label();
            spec_label = new Label();
            group_textbox = new TextBox();
            spec_textbox = new TextBox();
            learning_form_label = new Label();
            groupBox2 = new GroupBox();
            online_radiobutton = new RadioButton();
            offline_radiobutton = new RadioButton();
            label_top = new Label();
            add_info_button = new Button();
            back_to_main_button = new Button();
            maskedTextBox1 = new MaskedTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Segoe UI", 12F);
            surname_label.Location = new Point(190, 113);
            surname_label.Margin = new Padding(4, 0, 4, 0);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(75, 21);
            surname_label.TabIndex = 0;
            surname_label.Text = "Фамилия";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 12F);
            name_label.Location = new Point(190, 177);
            name_label.Margin = new Padding(4, 0, 4, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(41, 21);
            name_label.TabIndex = 1;
            name_label.Text = "Имя";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Location = new Point(190, 236);
            lastname_label.Margin = new Padding(4, 0, 4, 0);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(77, 21);
            lastname_label.TabIndex = 2;
            lastname_label.Text = "Отчество";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Location = new Point(190, 291);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(121, 21);
            age_label.TabIndex = 3;
            age_label.Text = "Дата рождения";
            // 
            // surname_textbox
            // 
            surname_textbox.Location = new Point(379, 113);
            surname_textbox.Margin = new Padding(4);
            surname_textbox.Name = "surname_textbox";
            surname_textbox.Size = new Size(229, 29);
            surname_textbox.TabIndex = 4;
            surname_textbox.Enter += surname_textbox_Enter;
            surname_textbox.Leave += surname_textbox_Leave;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(379, 177);
            name_textbox.Margin = new Padding(4);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(229, 29);
            name_textbox.TabIndex = 5;
            name_textbox.Enter += name_textbox_Enter;
            name_textbox.Leave += name_textbox_Leave;
            // 
            // lastname_textbox
            // 
            lastname_textbox.Location = new Point(379, 233);
            lastname_textbox.Margin = new Padding(4);
            lastname_textbox.Name = "lastname_textbox";
            lastname_textbox.Size = new Size(229, 29);
            lastname_textbox.TabIndex = 6;
            lastname_textbox.Enter += lastname_textbox_Enter;
            lastname_textbox.Leave += lastname_textbox_Leave;
            // 
            // label_sex
            // 
            label_sex.AutoSize = true;
            label_sex.Location = new Point(190, 404);
            label_sex.Margin = new Padding(4, 0, 4, 0);
            label_sex.Name = "label_sex";
            label_sex.Size = new Size(38, 21);
            label_sex.TabIndex = 8;
            label_sex.Text = "Пол";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radio_button_female);
            groupBox1.Controls.Add(radio_button_male);
            groupBox1.Location = new Point(379, 320);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(128, 148);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // radio_button_female
            // 
            radio_button_female.AutoSize = true;
            radio_button_female.Location = new Point(16, 86);
            radio_button_female.Margin = new Padding(4);
            radio_button_female.Name = "radio_button_female";
            radio_button_female.Size = new Size(92, 25);
            radio_button_female.TabIndex = 1;
            radio_button_female.TabStop = true;
            radio_button_female.Text = "Женский";
            radio_button_female.UseVisualStyleBackColor = true;
            // 
            // radio_button_male
            // 
            radio_button_male.AutoSize = true;
            radio_button_male.Location = new Point(18, 31);
            radio_button_male.Margin = new Padding(4);
            radio_button_male.Name = "radio_button_male";
            radio_button_male.Size = new Size(95, 25);
            radio_button_male.TabIndex = 0;
            radio_button_male.TabStop = true;
            radio_button_male.Text = "Мужской";
            radio_button_male.UseVisualStyleBackColor = true;
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Location = new Point(190, 507);
            faculcy_label.Margin = new Padding(4, 0, 4, 0);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(84, 21);
            faculcy_label.TabIndex = 11;
            faculcy_label.Text = "Факультет";
            // 
            // faculty_textbox
            // 
            faculty_textbox.Location = new Point(379, 507);
            faculty_textbox.Margin = new Padding(4);
            faculty_textbox.Name = "faculty_textbox";
            faculty_textbox.Size = new Size(229, 29);
            faculty_textbox.TabIndex = 12;
            faculty_textbox.Enter += faculty_textbox_Enter;
            faculty_textbox.Leave += faculty_textbox_Leave;
            // 
            // group_label
            // 
            group_label.AutoSize = true;
            group_label.Location = new Point(190, 573);
            group_label.Margin = new Padding(4, 0, 4, 0);
            group_label.Name = "group_label";
            group_label.Size = new Size(61, 21);
            group_label.TabIndex = 13;
            group_label.Text = "Группа";
            // 
            // spec_label
            // 
            spec_label.AutoSize = true;
            spec_label.Location = new Point(190, 643);
            spec_label.Margin = new Padding(4, 0, 4, 0);
            spec_label.Name = "spec_label";
            spec_label.Size = new Size(120, 21);
            spec_label.TabIndex = 14;
            spec_label.Text = "Специальность";
            // 
            // group_textbox
            // 
            group_textbox.Location = new Point(379, 573);
            group_textbox.Margin = new Padding(4);
            group_textbox.Name = "group_textbox";
            group_textbox.Size = new Size(229, 29);
            group_textbox.TabIndex = 15;
            group_textbox.Enter += group_textbox_Enter;
            // 
            // spec_textbox
            // 
            spec_textbox.Location = new Point(379, 643);
            spec_textbox.Margin = new Padding(4);
            spec_textbox.Name = "spec_textbox";
            spec_textbox.Size = new Size(229, 29);
            spec_textbox.TabIndex = 16;
            spec_textbox.Enter += spec_textbox_Enter;
            spec_textbox.Leave += spec_textbox_Leave;
            // 
            // learning_form_label
            // 
            learning_form_label.AutoSize = true;
            learning_form_label.Location = new Point(190, 740);
            learning_form_label.Margin = new Padding(4, 0, 4, 0);
            learning_form_label.Name = "learning_form_label";
            learning_form_label.Size = new Size(132, 21);
            learning_form_label.TabIndex = 17;
            learning_form_label.Text = "Форма обучения";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(online_radiobutton);
            groupBox2.Controls.Add(offline_radiobutton);
            groupBox2.Location = new Point(379, 703);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(128, 148);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            // 
            // online_radiobutton
            // 
            online_radiobutton.AutoSize = true;
            online_radiobutton.Location = new Point(16, 86);
            online_radiobutton.Margin = new Padding(4);
            online_radiobutton.Name = "online_radiobutton";
            online_radiobutton.Size = new Size(88, 25);
            online_radiobutton.TabIndex = 1;
            online_radiobutton.TabStop = true;
            online_radiobutton.Text = "Заочная";
            online_radiobutton.UseVisualStyleBackColor = true;
            // 
            // offline_radiobutton
            // 
            offline_radiobutton.AutoSize = true;
            offline_radiobutton.Location = new Point(18, 31);
            offline_radiobutton.Margin = new Padding(4);
            offline_radiobutton.Name = "offline_radiobutton";
            offline_radiobutton.Size = new Size(74, 25);
            offline_radiobutton.TabIndex = 0;
            offline_radiobutton.TabStop = true;
            offline_radiobutton.Text = "Очная";
            offline_radiobutton.UseVisualStyleBackColor = true;
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Segoe UI", 20F);
            label_top.Location = new Point(246, 33);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(341, 37);
            label_top.TabIndex = 19;
            label_top.Text = "Введите данные пациента";
            // 
            // add_info_button
            // 
            add_info_button.Location = new Point(622, 875);
            add_info_button.Name = "add_info_button";
            add_info_button.Size = new Size(197, 57);
            add_info_button.TabIndex = 20;
            add_info_button.Text = "Сохранить";
            add_info_button.UseVisualStyleBackColor = true;
            add_info_button.Click += add_info_button_Click;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(31, 875);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 21;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(379, 288);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(68, 29);
            maskedTextBox1.TabIndex = 23;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(842, 973);
            Controls.Add(maskedTextBox1);
            Controls.Add(back_to_main_button);
            Controls.Add(add_info_button);
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
            Controls.Add(surname_textbox);
            Controls.Add(age_label);
            Controls.Add(lastname_label);
            Controls.Add(name_label);
            Controls.Add(surname_label);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Label label_sex;
        private GroupBox groupBox1;
        private RadioButton radio_button_male;
        private RadioButton radio_button_female;
        private Label faculcy_label;
        private TextBox faculty_textbox;
        private Label group_label;
        private Label spec_label;
        private TextBox group_textbox;
        private TextBox spec_textbox;
        private Label learning_form_label;
        private GroupBox groupBox2;
        private RadioButton online_radiobutton;
        private RadioButton offline_radiobutton;
        private Label label_top;
        private Button add_info_button;
        private Button back_to_main_button;
        private MaskedTextBox maskedTextBox1;
    }
}