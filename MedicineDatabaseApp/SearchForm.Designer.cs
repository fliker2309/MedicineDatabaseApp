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
            searchButton = new Button();
            label_top = new Label();
            spec_label = new Label();
            group_label = new Label();
            faculcy_label = new Label();
            label_sex = new Label();
            age_label = new Label();
            label1 = new Label();
            ageComboBox = new ComboBox();
            label2 = new Label();
            yearComboBox = new ComboBox();
            facultyBox = new ComboBox();
            groupBox = new ComboBox();
            specialityBox = new ComboBox();
            sexComboBox = new ComboBox();
            studentsListView = new ListView();
            button1 = new Button();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            searchButton.Location = new Point(998, 649);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(76, 27);
            searchButton.TabIndex = 42;
            searchButton.Text = "Поиск";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
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
            // spec_label
            // 
            spec_label.AutoSize = true;
            spec_label.Font = new Font("Trebuchet MS", 11.25F);
            spec_label.Location = new Point(469, 263);
            spec_label.Margin = new Padding(4, 0, 4, 0);
            spec_label.Name = "spec_label";
            spec_label.Size = new Size(113, 20);
            spec_label.TabIndex = 36;
            spec_label.Text = "Специальность";
            // 
            // group_label
            // 
            group_label.AutoSize = true;
            group_label.Font = new Font("Trebuchet MS", 11.25F);
            group_label.Location = new Point(104, 269);
            group_label.Margin = new Padding(4, 0, 4, 0);
            group_label.Name = "group_label";
            group_label.Size = new Size(56, 20);
            group_label.TabIndex = 35;
            group_label.Text = "Группа";
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Font = new Font("Trebuchet MS", 11.25F);
            faculcy_label.Location = new Point(469, 192);
            faculcy_label.Margin = new Padding(4, 0, 4, 0);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(81, 20);
            faculcy_label.TabIndex = 33;
            faculcy_label.Text = "Факультет";
            // 
            // label_sex
            // 
            label_sex.AutoSize = true;
            label_sex.Font = new Font("Trebuchet MS", 11.25F);
            label_sex.Location = new Point(104, 189);
            label_sex.Margin = new Padding(4, 0, 4, 0);
            label_sex.Name = "label_sex";
            label_sex.Size = new Size(35, 20);
            label_sex.TabIndex = 31;
            label_sex.Text = "Пол";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Trebuchet MS", 11.25F);
            age_label.Location = new Point(101, 109);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(108, 20);
            age_label.TabIndex = 27;
            age_label.Text = "Год рождения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F);
            label1.Location = new Point(489, 30);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 44;
            label1.Text = "Поиск по параметрам";
            // 
            // ageComboBox
            // 
            ageComboBox.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ageComboBox.FormattingEnabled = true;
            ageComboBox.Location = new Point(242, 104);
            ageComboBox.Name = "ageComboBox";
            ageComboBox.Size = new Size(121, 32);
            ageComboBox.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F);
            label2.Location = new Point(469, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 46;
            label2.Text = "Год поступления";
            // 
            // yearComboBox
            // 
            yearComboBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(685, 104);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(121, 30);
            yearComboBox.TabIndex = 47;
            // 
            // facultyBox
            // 
            facultyBox.Font = new Font("Trebuchet MS", 12F);
            facultyBox.FormattingEnabled = true;
            facultyBox.Location = new Point(685, 182);
            facultyBox.Name = "facultyBox";
            facultyBox.Size = new Size(389, 30);
            facultyBox.TabIndex = 48;
            // 
            // groupBox
            // 
            groupBox.Font = new Font("Trebuchet MS", 12F);
            groupBox.FormattingEnabled = true;
            groupBox.Location = new Point(242, 259);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(121, 30);
            groupBox.TabIndex = 49;
            // 
            // specialityBox
            // 
            specialityBox.Font = new Font("Trebuchet MS", 12F);
            specialityBox.FormattingEnabled = true;
            specialityBox.Location = new Point(685, 262);
            specialityBox.Name = "specialityBox";
            specialityBox.Size = new Size(389, 30);
            specialityBox.TabIndex = 50;
            // 
            // sexComboBox
            // 
            sexComboBox.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sexComboBox.FormattingEnabled = true;
            sexComboBox.Location = new Point(242, 180);
            sexComboBox.Name = "sexComboBox";
            sexComboBox.Size = new Size(121, 32);
            sexComboBox.TabIndex = 51;
            // 
            // studentsListView
            // 
            studentsListView.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            studentsListView.Location = new Point(104, 320);
            studentsListView.Name = "studentsListView";
            studentsListView.Size = new Size(970, 290);
            studentsListView.TabIndex = 52;
            studentsListView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(104, 649);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 53;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1246, 733);
            Controls.Add(button1);
            Controls.Add(studentsListView);
            Controls.Add(sexComboBox);
            Controls.Add(specialityBox);
            Controls.Add(groupBox);
            Controls.Add(facultyBox);
            Controls.Add(yearComboBox);
            Controls.Add(label2);
            Controls.Add(ageComboBox);
            Controls.Add(label1);
            Controls.Add(searchButton);
            Controls.Add(label_top);
            Controls.Add(spec_label);
            Controls.Add(group_label);
            Controls.Add(faculcy_label);
            Controls.Add(label_sex);
            Controls.Add(age_label);
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button searchButton;
        private Label label_top;
        private Label spec_label;
        private Label group_label;
        private Label faculcy_label;
        private Label label_sex;
        private Label age_label;
        private Label label1;
        private ComboBox ageComboBox;
        private Label label2;
        private ComboBox yearComboBox;
        private ComboBox facultyBox;
        private ComboBox groupBox;
        private ComboBox specialityBox;
        private ComboBox sexComboBox;
        private ListView studentsListView;
        private Button button1;
    }
}