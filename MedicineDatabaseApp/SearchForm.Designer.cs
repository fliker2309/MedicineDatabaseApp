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
            filterBtn = new Button();
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
            backBtn = new Button();
            deleteBtn = new Button();
            EditBtn = new Button();
            addStudentBtn = new Button();
            SuspendLayout();
            // 
            // filterBtn
            // 
            filterBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            filterBtn.Location = new Point(892, 80);
            filterBtn.Name = "filterBtn";
            filterBtn.Size = new Size(182, 56);
            filterBtn.TabIndex = 42;
            filterBtn.Text = "Применить / Очистить фильтр";
            filterBtn.UseVisualStyleBackColor = true;
            filterBtn.Click += searchButton_Click;
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
            spec_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            spec_label.Location = new Point(525, 266);
            spec_label.Margin = new Padding(4, 0, 4, 0);
            spec_label.Name = "spec_label";
            spec_label.Size = new Size(137, 21);
            spec_label.TabIndex = 36;
            spec_label.Text = "Специальность";
            // 
            // group_label
            // 
            group_label.AutoSize = true;
            group_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            group_label.Location = new Point(104, 269);
            group_label.Margin = new Padding(4, 0, 4, 0);
            group_label.Name = "group_label";
            group_label.Size = new Size(68, 21);
            group_label.TabIndex = 35;
            group_label.Text = "Группа";
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            faculcy_label.Location = new Point(525, 191);
            faculcy_label.Margin = new Padding(4, 0, 4, 0);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(104, 21);
            faculcy_label.TabIndex = 33;
            faculcy_label.Text = "Факультет";
            // 
            // label_sex
            // 
            label_sex.AutoSize = true;
            label_sex.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            label_sex.Location = new Point(104, 189);
            label_sex.Margin = new Padding(4, 0, 4, 0);
            label_sex.Name = "label_sex";
            label_sex.Size = new Size(41, 21);
            label_sex.TabIndex = 31;
            label_sex.Text = "Пол";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            age_label.Location = new Point(101, 109);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(127, 21);
            age_label.TabIndex = 27;
            age_label.Text = "Год рождения";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(379, 20);
            label1.Name = "label1";
            label1.Size = new Size(359, 36);
            label1.TabIndex = 44;
            label1.Text = "Фильтр по параметрам";
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
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            label2.Location = new Point(525, 108);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 21);
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
            studentsListView.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            studentsListView.FullRowSelect = true;
            studentsListView.Location = new Point(24, 342);
            studentsListView.Name = "studentsListView";
            studentsListView.Size = new Size(1177, 243);
            studentsListView.TabIndex = 52;
            studentsListView.UseCompatibleStateImageBehavior = false;      
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            backBtn.Location = new Point(12, 668);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(130, 53);
            backBtn.TabIndex = 53;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += button1_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            deleteBtn.ForeColor = Color.Red;
            deleteBtn.Location = new Point(550, 649);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(186, 53);
            deleteBtn.TabIndex = 54;
            deleteBtn.Text = "Удалить студента";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            EditBtn.Location = new Point(769, 649);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(165, 53);
            EditBtn.TabIndex = 55;
            EditBtn.Text = "Редактирование";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // addStudentBtn
            // 
            addStudentBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            addStudentBtn.Location = new Point(325, 649);
            addStudentBtn.Name = "addStudentBtn";
            addStudentBtn.Size = new Size(194, 53);
            addStudentBtn.TabIndex = 56;
            addStudentBtn.Text = "Добавить студента";
            addStudentBtn.UseVisualStyleBackColor = true;
            addStudentBtn.Click += addStudentBtn_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1246, 733);
            ControlBox = false;
            Controls.Add(addStudentBtn);
            Controls.Add(EditBtn);
            Controls.Add(deleteBtn);
            Controls.Add(backBtn);
            Controls.Add(studentsListView);
            Controls.Add(sexComboBox);
            Controls.Add(specialityBox);
            Controls.Add(groupBox);
            Controls.Add(facultyBox);
            Controls.Add(yearComboBox);
            Controls.Add(label2);
            Controls.Add(ageComboBox);
            Controls.Add(label1);
            Controls.Add(filterBtn);
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
        private Button filterBtn;
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
        private Button backBtn;
        private Button deleteBtn;
        private Button EditBtn;
        private Button addStudentBtn;
    }
}