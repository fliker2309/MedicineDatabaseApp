namespace MedicineDatabaseApp
{
    partial class EditVrachForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            VrachlistView = new ListView();
            VexpTimePicker = new DateTimePicker();
            Vborndate_datepicker = new DateTimePicker();
            label4 = new Label();
            VqualityTB = new TextBox();
            VjobtitleTB = new TextBox();
            VlastnameTB = new TextBox();
            VnameTB = new TextBox();
            Vsurname_textbox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            faculcy_label = new Label();
            age_label = new Label();
            lastname_label = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(82, 573);
            button1.Name = "button1";
            button1.Size = new Size(114, 44);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(507, 570);
            button2.Name = "button2";
            button2.Size = new Size(112, 44);
            button2.TabIndex = 1;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(877, 572);
            button3.Name = "button3";
            button3.Size = new Size(113, 42);
            button3.TabIndex = 2;
            button3.Text = "Сохранить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(385, 19);
            label1.Name = "label1";
            label1.Size = new Size(330, 54);
            label1.TabIndex = 3;
            label1.Text = "Список врачей";
            // 
            // VrachlistView
            // 
            VrachlistView.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            VrachlistView.FullRowSelect = true;
            VrachlistView.Location = new Point(12, 88);
            VrachlistView.Name = "VrachlistView";
            VrachlistView.Size = new Size(1102, 240);
            VrachlistView.TabIndex = 4;
            VrachlistView.UseCompatibleStateImageBehavior = false;
            // 
            // VexpTimePicker
            // 
            VexpTimePicker.Font = new Font("Times New Roman", 14.25F);
            VexpTimePicker.Location = new Point(254, 510);
            VexpTimePicker.Name = "VexpTimePicker";
            VexpTimePicker.Size = new Size(229, 29);
            VexpTimePicker.TabIndex = 49;
            // 
            // Vborndate_datepicker
            // 
            Vborndate_datepicker.Font = new Font("Times New Roman", 14.25F);
            Vborndate_datepicker.Location = new Point(761, 397);
            Vborndate_datepicker.Name = "Vborndate_datepicker";
            Vborndate_datepicker.Size = new Size(229, 29);
            Vborndate_datepicker.TabIndex = 48;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            label4.Location = new Point(81, 518);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 21);
            label4.TabIndex = 47;
            label4.Text = "Стаж работы";
            // 
            // VqualityTB
            // 
            VqualityTB.Font = new Font("Times New Roman", 14.25F);
            VqualityTB.Location = new Point(761, 455);
            VqualityTB.Margin = new Padding(4);
            VqualityTB.Name = "VqualityTB";
            VqualityTB.Size = new Size(229, 29);
            VqualityTB.TabIndex = 46;
            // 
            // VjobtitleTB
            // 
            VjobtitleTB.Font = new Font("Times New Roman", 14.25F);
            VjobtitleTB.Location = new Point(254, 455);
            VjobtitleTB.Margin = new Padding(4);
            VjobtitleTB.Name = "VjobtitleTB";
            VjobtitleTB.Size = new Size(229, 29);
            VjobtitleTB.TabIndex = 45;
            // 
            // VlastnameTB
            // 
            VlastnameTB.Font = new Font("Times New Roman", 14.25F);
            VlastnameTB.Location = new Point(254, 405);
            VlastnameTB.Margin = new Padding(4);
            VlastnameTB.Name = "VlastnameTB";
            VlastnameTB.Size = new Size(229, 29);
            VlastnameTB.TabIndex = 44;
            // 
            // VnameTB
            // 
            VnameTB.Font = new Font("Times New Roman", 14.25F);
            VnameTB.Location = new Point(761, 357);
            VnameTB.Margin = new Padding(4);
            VnameTB.Name = "VnameTB";
            VnameTB.Size = new Size(229, 29);
            VnameTB.TabIndex = 43;
            // 
            // Vsurname_textbox
            // 
            Vsurname_textbox.Font = new Font("Times New Roman", 14.25F);
            Vsurname_textbox.Location = new Point(254, 357);
            Vsurname_textbox.Margin = new Padding(4);
            Vsurname_textbox.Name = "Vsurname_textbox";
            Vsurname_textbox.Size = new Size(229, 29);
            Vsurname_textbox.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            label3.Location = new Point(79, 357);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(84, 21);
            label3.TabIndex = 41;
            label3.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            label2.Location = new Point(586, 364);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 21);
            label2.TabIndex = 40;
            label2.Text = "Имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            label5.Location = new Point(586, 463);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 39;
            label5.Text = "Квалификация";
            // 
            // faculcy_label
            // 
            faculcy_label.AutoSize = true;
            faculcy_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            faculcy_label.Location = new Point(79, 458);
            faculcy_label.Margin = new Padding(4, 0, 4, 0);
            faculcy_label.Name = "faculcy_label";
            faculcy_label.Size = new Size(106, 21);
            faculcy_label.TabIndex = 38;
            faculcy_label.Text = "Должность";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            age_label.Location = new Point(586, 405);
            age_label.Margin = new Padding(4, 0, 4, 0);
            age_label.Name = "age_label";
            age_label.Size = new Size(144, 21);
            age_label.TabIndex = 37;
            age_label.Text = "Дата рождения";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Italic);
            lastname_label.Location = new Point(79, 416);
            lastname_label.Margin = new Padding(4, 0, 4, 0);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(94, 21);
            lastname_label.TabIndex = 36;
            lastname_label.Text = "Отчество";
            // 
            // EditVrachForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1136, 639);
            Controls.Add(VexpTimePicker);
            Controls.Add(Vborndate_datepicker);
            Controls.Add(label4);
            Controls.Add(VqualityTB);
            Controls.Add(VjobtitleTB);
            Controls.Add(VlastnameTB);
            Controls.Add(VnameTB);
            Controls.Add(Vsurname_textbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(faculcy_label);
            Controls.Add(age_label);
            Controls.Add(lastname_label);
            Controls.Add(VrachlistView);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditVrachForm";
            Text = "EditVrach";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private ListView VrachlistView;
        private DateTimePicker VexpTimePicker;
        private DateTimePicker Vborndate_datepicker;
        private Label label4;
        private TextBox VqualityTB;
        private TextBox VjobtitleTB;
        private TextBox VlastnameTB;
        private TextBox VnameTB;
        private TextBox Vsurname_textbox;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label faculcy_label;
        private Label age_label;
        private Label lastname_label;
    }
}