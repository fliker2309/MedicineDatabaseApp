namespace MedicineDatabaseApp
{
    partial class AddSpecialityForm
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
            label_top = new Label();
            button2 = new Button();
            button1 = new Button();
            specialityTextBox = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label_top
            // 
            label_top.AutoSize = true;
            label_top.Font = new Font("Segoe UI", 20F);
            label_top.Location = new Point(237, 36);
            label_top.Margin = new Padding(4, 0, 4, 0);
            label_top.Name = "label_top";
            label_top.Size = new Size(329, 37);
            label_top.TabIndex = 59;
            label_top.Text = "Добавить специальность";
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 12F);
            button2.Location = new Point(597, 292);
            button2.Name = "button2";
            button2.Size = new Size(105, 38);
            button2.TabIndex = 55;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 12F);
            button1.Location = new Point(80, 292);
            button1.Name = "button1";
            button1.Size = new Size(105, 38);
            button1.TabIndex = 58;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // specialityTextBox
            // 
            specialityTextBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            specialityTextBox.Location = new Point(317, 163);
            specialityTextBox.Name = "specialityTextBox";
            specialityTextBox.Size = new Size(397, 26);
            specialityTextBox.TabIndex = 57;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(56, 163);
            label4.Name = "label4";
            label4.Size = new Size(158, 27);
            label4.TabIndex = 56;
            label4.Text = "Специальность";
            // 
            // AddSpecialityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(808, 445);
            Controls.Add(label_top);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(specialityTextBox);
            Controls.Add(label4);
            Name = "AddSpecialityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSpecialityForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_top;
        private Button button2;
        private Button button1;
        private TextBox specialityTextBox;
        private Label label4;
    }
}