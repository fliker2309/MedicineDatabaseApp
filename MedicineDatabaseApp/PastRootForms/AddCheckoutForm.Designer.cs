namespace MedicineDatabaseApp
{
    partial class AddCheckoutForm
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            button1 = new Button();
            back_to_main_button = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(593, 208);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 23);
            comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(111, 191);
            label1.Name = "label1";
            label1.Size = new Size(254, 35);
            label1.TabIndex = 4;
            label1.Text = "Выберите студента";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(593, 355);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(56, 23);
            maskedTextBox1.TabIndex = 27;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(111, 342);
            label2.Name = "label2";
            label2.Size = new Size(410, 35);
            label2.TabIndex = 26;
            label2.Text = "Дата прохождения медосмотра";
            // 
            // button1
            // 
            button1.Location = new Point(593, 906);
            button1.Name = "button1";
            button1.Size = new Size(197, 57);
            button1.TabIndex = 29;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(111, 906);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 28;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(504, 494);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 23);
            textBox1.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(111, 482);
            label3.Name = "label3";
            label3.Size = new Size(242, 35);
            label3.TabIndex = 30;
            label3.Text = "Уровень здоровья";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(111, 593);
            label4.Name = "label4";
            label4.Size = new Size(306, 35);
            label4.TabIndex = 32;
            label4.Text = "Группа по физкультуре";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(587, 605);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(203, 23);
            comboBox2.TabIndex = 33;
            // 
            // AddCheckoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(931, 1046);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(back_to_main_button);
            Controls.Add(maskedTextBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "AddCheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddCheckoutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Button button1;
        private Button back_to_main_button;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private ComboBox comboBox2;
    }
}