namespace MedicineDatabaseApp
{
    partial class AddCertificateForm
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
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            back_to_main_button = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            dropStudents = new ComboBox();
            label1 = new Label();
            maskedTextBox2 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(175, 591);
            label4.Name = "label4";
            label4.Size = new Size(197, 35);
            label4.TabIndex = 52;
            label4.Text = "Срок действия";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(502, 469);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 23);
            textBox1.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(175, 456);
            label3.Name = "label3";
            label3.Size = new Size(170, 35);
            label3.TabIndex = 50;
            label3.Text = "Тип справки";
            // 
            // button1
            // 
            button1.Location = new Point(661, 830);
            button1.Name = "button1";
            button1.Size = new Size(197, 57);
            button1.TabIndex = 49;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(143, 850);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 48;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(661, 340);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(55, 23);
            maskedTextBox1.TabIndex = 47;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(175, 340);
            label2.Name = "label2";
            label2.Size = new Size(174, 35);
            label2.TabIndex = 46;
            label2.Text = "Дата выдачи";
            // 
            // dropStudents
            // 
            dropStudents.FormattingEnabled = true;
            dropStudents.Location = new Point(591, 215);
            dropStudents.Name = "dropStudents";
            dropStudents.Size = new Size(203, 23);
            dropStudents.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(175, 215);
            label1.Name = "label1";
            label1.Size = new Size(254, 35);
            label1.TabIndex = 44;
            label1.Text = "Выберите студента";
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox2.Location = new Point(661, 603);
            maskedTextBox2.Mask = "00/00/0000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(55, 23);
            maskedTextBox2.TabIndex = 53;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // AddCertificateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(986, 1057);
            Controls.Add(maskedTextBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(back_to_main_button);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(dropStudents);
            Controls.Add(label1);
            Name = "AddCertificateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCertificateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button back_to_main_button;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private ComboBox dropStudents;
        private Label label1;
        private MaskedTextBox maskedTextBox2;
    }
}