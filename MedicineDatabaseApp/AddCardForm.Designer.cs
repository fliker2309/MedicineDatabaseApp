namespace MedicineDatabaseApp
{
    partial class AddCardForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(128, 580);
            label4.Name = "label4";
            label4.Size = new Size(117, 35);
            label4.TabIndex = 42;
            label4.Text = "Диагноз";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(455, 469);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 23);
            textBox1.TabIndex = 41;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(128, 469);
            label3.Name = "label3";
            label3.Size = new Size(117, 35);
            label3.TabIndex = 40;
            label3.Text = "Жалобы";
            // 
            // button1
            // 
            button1.Location = new Point(583, 795);
            button1.Name = "button1";
            button1.Size = new Size(197, 57);
            button1.TabIndex = 39;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(81, 795);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 38;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(544, 342);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(122, 23);
            maskedTextBox1.TabIndex = 37;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(96, 330);
            label2.Name = "label2";
            label2.Size = new Size(220, 35);
            label2.TabIndex = 36;
            label2.Text = "Дата посещения";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(544, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 23);
            comboBox1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(81, 183);
            label1.Name = "label1";
            label1.Size = new Size(254, 35);
            label1.TabIndex = 34;
            label1.Text = "Выберите студента";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(455, 580);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 23);
            textBox2.TabIndex = 43;
            // 
            // AddCertificateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(891, 1002);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(back_to_main_button);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
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
        private ComboBox comboBox1;
        private Label label1;
        private TextBox textBox2;
    }
}