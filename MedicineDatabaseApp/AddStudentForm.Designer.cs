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
            lastname_label = new Label();
            age_label = new Label();
            surname_textbox = new TextBox();
            name_textbox = new TextBox();
            lastname_textbox = new TextBox();
            label_sex = new Label();
            radio_button_female = new RadioButton();
            male_radiobutton = new RadioButton();
            faculcy_label = new Label();
            group_label = new Label();
            spec_label = new Label();
            group_textbox = new TextBox();
            learning_form_label = new Label();
            label_top = new Label();
            add_info_button = new Button();
            back_to_main_button = new Button();
            borndate_datepicker = new DateTimePicker();
            label1 = new Label();
            startYearBox = new ComboBox();
            facultyBox = new ComboBox();
            specialityBox = new ComboBox();
            label2 = new Label();
            endYearBox = new ComboBox();
            panel1 = new Panel();
            offline_radiobutton = new RadioButton();
            online_radiobutton = new RadioButton();
            isOfflinePanel = new Panel();
            name_label = new Label();
            panel1.SuspendLayout();
            isOfflinePanel.SuspendLayout();
            SuspendLayout();
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Segoe UI", 12F);
            surname_label.Location = new Point(190, 58);
            surname_label.Margin = new Padding(4, 0, 4, 0);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(75, 21);
            surname_label.TabIndex = 0;
            surname_label.Text = "Фамилия";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Location = new Point(190, 165);
            lastname_label.Margin = new Padding(4, 0, 4, 0);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(77, 21);
            lastname_label.TabIndex = 2;
            lastname_label.Text = "Отчество";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Location = new Point(190, 218);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(121, 21);
            age_label.TabIndex = 3;
            age_label.Text = "Дата рождения";
            // 
            // surname_textbox
            // 
            surname_textbox.Location = new Point(379, 58);
            surname_textbox.Margin = new Padding(4);
            surname_textbox.Name = "surname_textbox";
            surname_textbox.Size = new Size(229, 29);
            surname_textbox.TabIndex = 4;
            surname_textbox.Enter += surname_textbox_Enter;
            surname_textbox.Leave += surname_textbox_Leave;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(379, 117);
            name_textbox.Margin = new Padding(4);
            name_textbox.Name = "name_textbox";
            name_textbox.Size = new Size(229, 29);
            name_textbox.TabIndex = 5;
            name_textbox.Enter += name_textbox_Enter;
            name_textbox.Leave += name_textbox_Leave;
            // 
            // lastname_textbox
            // 
            lastname_textbox.Location = new Point(379, 165);
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
            label_sex.Location = new Point(190, 266);
            label_sex.Margin = new Padding(4, 0, 4, 0);
            label_sex.Name = "label_sex";
            label_sex.Size = new Size(38, 21);
            label_sex.TabIndex = 8;
            label_sex.Text = "Пол";
            // 
            // radio_button_female
            // 
            radio_button_female.AutoSize = true;
            radio_button_female.Location = new Point(102, 8);
            radio_button_female.Margin = new Padding(4);
            radio_button_female.Name = "radio_button_female";
            radio_button_female.Size = new Size(92, 25);
            radio_button_female.TabIndex = 1;
            radio_button_female.TabStop = true;
            radio_button_female.Text = "Женский";
            radio_button_female.UseVisualStyleBackColor = true;
            // 
            // male_radiobutton
            // 
            male_radiobutton.AutoSize = true;
            male_radiobutton.Location = new Point(4, 8);
            male_radiobutton.Margin = new Padding(4);
            male_radiobutton.Name = "male_radiobutton";
            male_radiobutton.Size = new Size(95, 25);
            male_radiobutton.TabIndex = 0;
            male_radiobutton.TabStop = true;
            male_radiobutton.Text = "Мужской";
            male_radiobutton.UseVisualStyleBackColor = true;
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Location = new Point(190, 328);
            faculcy_label.Margin = new Padding(4, 0, 4, 0);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(84, 21);
            faculcy_label.TabIndex = 11;
            faculcy_label.Text = "Факультет";
            // 
            // group_label
            // 
            group_label.AutoSize = true;
            group_label.Location = new Point(190, 404);
            group_label.Margin = new Padding(4, 0, 4, 0);
            group_label.Name = "group_label";
            group_label.Size = new Size(61, 21);
            group_label.TabIndex = 13;
            group_label.Text = "Группа";
            // 
            // spec_label
            // 
            spec_label.AutoSize = true;
            spec_label.Location = new Point(190, 368);
            spec_label.Margin = new Padding(4, 0, 4, 0);
            spec_label.Name = "spec_label";
            spec_label.Size = new Size(120, 21);
            spec_label.TabIndex = 14;
            spec_label.Text = "Специальность";
            // 
            // group_textbox
            // 
            group_textbox.Location = new Point(379, 396);
            group_textbox.Margin = new Padding(4);
            group_textbox.Name = "group_textbox";
            group_textbox.Size = new Size(229, 29);
            group_textbox.TabIndex = 15;
            group_textbox.Enter += group_textbox_Enter;
            group_textbox.Leave += group_textbox_Leave_1;
            // 
            // learning_form_label
            // 
            learning_form_label.AutoSize = true;
            learning_form_label.Location = new Point(190, 436);
            learning_form_label.Margin = new Padding(4, 0, 4, 0);
            learning_form_label.Name = "learning_form_label";
            learning_form_label.Size = new Size(132, 21);
            learning_form_label.TabIndex = 17;
            learning_form_label.Text = "Форма обучения";
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Segoe UI", 20F);
            label_top.Location = new Point(253, 9);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(330, 37);
            label_top.TabIndex = 19;
            label_top.Text = "Введите данные студента";
            // 
            // add_info_button
            // 
            add_info_button.Location = new Point(581, 564);
            add_info_button.Name = "add_info_button";
            add_info_button.Size = new Size(197, 57);
            add_info_button.TabIndex = 20;
            add_info_button.Text = "Сохранить";
            add_info_button.UseVisualStyleBackColor = true;
            add_info_button.Click += add_info_button_Click;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(113, 564);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 21;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // borndate_datepicker
            // 
            borndate_datepicker.Location = new Point(379, 218);
            borndate_datepicker.Name = "borndate_datepicker";
            borndate_datepicker.Size = new Size(296, 29);
            borndate_datepicker.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 471);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 21);
            label1.TabIndex = 25;
            label1.Text = "Год поступления";
            // 
            // startYearBox
            // 
            startYearBox.FormattingEnabled = true;
            startYearBox.Location = new Point(379, 463);
            startYearBox.Name = "startYearBox";
            startYearBox.Size = new Size(128, 29);
            startYearBox.TabIndex = 26;
            // 
            // facultyBox
            // 
            facultyBox.FormattingEnabled = true;
            facultyBox.Location = new Point(379, 325);
            facultyBox.Name = "facultyBox";
            facultyBox.Size = new Size(399, 29);
            facultyBox.TabIndex = 27;
            // 
            // specialityBox
            // 
            specialityBox.FormattingEnabled = true;
            specialityBox.Location = new Point(379, 360);
            specialityBox.Name = "specialityBox";
            specialityBox.Size = new Size(399, 29);
            specialityBox.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 506);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 29;
            label2.Text = "Год выпуска";
            // 
            // endYearBox
            // 
            endYearBox.FormattingEnabled = true;
            endYearBox.Location = new Point(379, 498);
            endYearBox.Name = "endYearBox";
            endYearBox.Size = new Size(128, 29);
            endYearBox.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.Controls.Add(radio_button_female);
            panel1.Controls.Add(male_radiobutton);
            panel1.Location = new Point(379, 262);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 37);
            panel1.TabIndex = 31;
            // 
            // offline_radiobutton
            // 
            offline_radiobutton.AutoSize = true;
            offline_radiobutton.Location = new Point(0, 0);
            offline_radiobutton.Margin = new Padding(4);
            offline_radiobutton.Name = "offline_radiobutton";
            offline_radiobutton.Size = new Size(74, 25);
            offline_radiobutton.TabIndex = 0;
            offline_radiobutton.TabStop = true;
            offline_radiobutton.Text = "Очная";
            offline_radiobutton.UseVisualStyleBackColor = true;
            // 
            // online_radiobutton
            // 
            online_radiobutton.AutoSize = true;
            online_radiobutton.Location = new Point(102, 0);
            online_radiobutton.Margin = new Padding(4);
            online_radiobutton.Name = "online_radiobutton";
            online_radiobutton.Size = new Size(88, 25);
            online_radiobutton.TabIndex = 1;
            online_radiobutton.TabStop = true;
            online_radiobutton.Text = "Заочная";
            online_radiobutton.UseVisualStyleBackColor = true;
            // 
            // isOfflinePanel
            // 
            isOfflinePanel.Controls.Add(offline_radiobutton);
            isOfflinePanel.Controls.Add(online_radiobutton);
            isOfflinePanel.Location = new Point(379, 432);
            isOfflinePanel.Name = "isOfflinePanel";
            isOfflinePanel.Size = new Size(215, 25);
            isOfflinePanel.TabIndex = 32;
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Segoe UI", 12F);
            name_label.Location = new Point(190, 117);
            name_label.Margin = new Padding(4, 0, 4, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(41, 21);
            name_label.TabIndex = 1;
            name_label.Text = "Имя";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(913, 663);
            Controls.Add(isOfflinePanel);
            Controls.Add(panel1);
            Controls.Add(endYearBox);
            Controls.Add(label2);
            Controls.Add(specialityBox);
            Controls.Add(facultyBox);
            Controls.Add(startYearBox);
            Controls.Add(label1);
            Controls.Add(borndate_datepicker);
            Controls.Add(back_to_main_button);
            Controls.Add(add_info_button);
            Controls.Add(label_top);
            Controls.Add(learning_form_label);
            Controls.Add(group_textbox);
            Controls.Add(spec_label);
            Controls.Add(group_label);
            Controls.Add(faculcy_label);
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
            Name = "AddStudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            isOfflinePanel.ResumeLayout(false);
            isOfflinePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label surname_label;
        private Label lastname_label;
        private Label age_label;
        private TextBox surname_textbox;
        private TextBox name_textbox;
        private TextBox lastname_textbox;
        private Label label_sex;
        private RadioButton male_radiobutton;
        private RadioButton radio_button_female;
        private Label faculcy_label;
        private Label group_label;
        private Label spec_label;
        private TextBox group_textbox;
        private Label learning_form_label;
        private Label label_top;
        private Button add_info_button;
        private Button back_to_main_button;
        private DateTimePicker borndate_datepicker;
        private Label label1;
        private ComboBox startYearBox;
        private ComboBox facultyBox;
        private ComboBox specialityBox;
        private Label label2;
        private ComboBox endYearBox;
        private Panel panel1;
        private RadioButton offline_radiobutton;
        private RadioButton online_radiobutton;
        private Panel isOfflinePanel;
        private Label name_label;
    }
}