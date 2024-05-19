namespace MedicineDatabaseApp
{
    partial class StudentDetailsForm
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
            label_sex = new Label();
            faculcy_label = new Label();
            spec_label = new Label();
            group_label = new Label();
            learning_form_label = new Label();
            start_label = new Label();
            end_label = new Label();
            back_to_main_button = new Button();
            showCardBtn = new Button();
            SuspendLayout();
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Font = new Font("Trebuchet MS", 11.25F);
            surname_label.Location = new Point(446, 76);
            surname_label.Margin = new Padding(4, 0, 4, 0);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(72, 20);
            surname_label.TabIndex = 1;
            surname_label.Text = "Фамилия";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Font = new Font("Trebuchet MS", 11.25F);
            name_label.Location = new Point(446, 116);
            name_label.Margin = new Padding(4, 0, 4, 0);
            name_label.Name = "name_label";
            name_label.Size = new Size(37, 20);
            name_label.TabIndex = 2;
            name_label.Text = "Имя";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Font = new Font("Trebuchet MS", 11.25F);
            lastname_label.Location = new Point(445, 160);
            lastname_label.Margin = new Padding(4, 0, 4, 0);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(72, 20);
            lastname_label.TabIndex = 3;
            lastname_label.Text = "Отчество";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Trebuchet MS", 11.25F);
            age_label.Location = new Point(446, 204);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(116, 20);
            age_label.TabIndex = 4;
            age_label.Text = "Дата рождения";
            // 
            // label_sex
            // 
            label_sex.AutoSize = true;
            label_sex.Font = new Font("Trebuchet MS", 11.25F);
            label_sex.Location = new Point(446, 245);
            label_sex.Margin = new Padding(4, 0, 4, 0);
            label_sex.Name = "label_sex";
            label_sex.Size = new Size(35, 20);
            label_sex.TabIndex = 9;
            label_sex.Text = "Пол";
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Font = new Font("Trebuchet MS", 11.25F);
            faculcy_label.Location = new Point(446, 287);
            faculcy_label.Margin = new Padding(4, 0, 4, 0);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(81, 20);
            faculcy_label.TabIndex = 12;
            faculcy_label.Text = "Факультет";
            // 
            // spec_label
            // 
            spec_label.AutoSize = true;
            spec_label.Font = new Font("Trebuchet MS", 11.25F);
            spec_label.Location = new Point(445, 328);
            spec_label.Margin = new Padding(4, 0, 4, 0);
            spec_label.Name = "spec_label";
            spec_label.Size = new Size(113, 20);
            spec_label.TabIndex = 15;
            spec_label.Text = "Специальность";
            // 
            // group_label
            // 
            group_label.AutoSize = true;
            group_label.Font = new Font("Trebuchet MS", 11.25F);
            group_label.Location = new Point(446, 369);
            group_label.Margin = new Padding(4, 0, 4, 0);
            group_label.Name = "group_label";
            group_label.Size = new Size(56, 20);
            group_label.TabIndex = 16;
            group_label.Text = "Группа";
            // 
            // learning_form_label
            // 
            learning_form_label.AutoSize = true;
            learning_form_label.Font = new Font("Trebuchet MS", 11.25F);
            learning_form_label.Location = new Point(445, 408);
            learning_form_label.Margin = new Padding(4, 0, 4, 0);
            learning_form_label.Name = "learning_form_label";
            learning_form_label.Size = new Size(123, 20);
            learning_form_label.TabIndex = 18;
            learning_form_label.Text = "Форма обучения";
            // 
            // start_label
            // 
            start_label.AutoSize = true;
            start_label.Font = new Font("Trebuchet MS", 11.25F);
            start_label.Location = new Point(445, 450);
            start_label.Margin = new Padding(4, 0, 4, 0);
            start_label.Name = "start_label";
            start_label.Size = new Size(125, 20);
            start_label.TabIndex = 26;
            start_label.Text = "Год поступления";
            // 
            // end_label
            // 
            end_label.AutoSize = true;
            end_label.Font = new Font("Trebuchet MS", 11.25F);
            end_label.Location = new Point(446, 496);
            end_label.Margin = new Padding(4, 0, 4, 0);
            end_label.Name = "end_label";
            end_label.Size = new Size(95, 20);
            end_label.TabIndex = 30;
            end_label.Text = "Год выпуска";
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(63, 626);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 31;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // showCardBtn
            // 
            showCardBtn.Location = new Point(780, 626);
            showCardBtn.Name = "showCardBtn";
            showCardBtn.Size = new Size(197, 57);
            showCardBtn.TabIndex = 32;
            showCardBtn.Text = "Показать мед карту";
            showCardBtn.UseVisualStyleBackColor = true;
            showCardBtn.Click += showCardBtn_Click;
            // 
            // StudentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1056, 724);
            Controls.Add(showCardBtn);
            Controls.Add(back_to_main_button);
            Controls.Add(end_label);
            Controls.Add(start_label);
            Controls.Add(learning_form_label);
            Controls.Add(group_label);
            Controls.Add(spec_label);
            Controls.Add(faculcy_label);
            Controls.Add(label_sex);
            Controls.Add(age_label);
            Controls.Add(lastname_label);
            Controls.Add(name_label);
            Controls.Add(surname_label);
            Name = "StudentDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label surname_label;
        private Label name_label;
        private Label lastname_label;
        private Label age_label;
        private Label label_sex;
        private Label faculcy_label;
        private Label spec_label;
        private Label group_label;
        private Label learning_form_label;
        private Label start_label;
        private Label end_label;
        private Button back_to_main_button;
        private Button showCardBtn;
    }
}