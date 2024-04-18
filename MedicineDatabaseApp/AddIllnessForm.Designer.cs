namespace MedicineDatabaseApp
{
    partial class AddIllnessForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            back_to_main_button = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(84, 183);
            label1.Name = "label1";
            label1.Size = new Size(254, 35);
            label1.TabIndex = 0;
            label1.Text = "Выберите студента";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(84, 317);
            label2.Name = "label2";
            label2.Size = new Size(334, 35);
            label2.TabIndex = 1;
            label2.Text = "Дата начала заболевания";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(84, 436);
            label3.Name = "label3";
            label3.Size = new Size(228, 35);
            label3.TabIndex = 2;
            label3.Text = "Тип заболевания";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(566, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(203, 23);
            comboBox1.TabIndex = 3;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(84, 793);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 22;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(566, 793);
            button1.Name = "button1";
            button1.Size = new Size(197, 57);
            button1.TabIndex = 23;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(477, 448);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 23);
            textBox1.TabIndex = 24;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            maskedTextBox1.Location = new Point(566, 330);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(56, 23);
            maskedTextBox1.TabIndex = 25;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // AddIllnessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(869, 915);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(back_to_main_button);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddIllnessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddIllnessForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox1;
        private Button back_to_main_button;
        private Button button1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
    }
}