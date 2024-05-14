namespace MedicineDatabaseApp
{
    partial class PastRootForm
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
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(77, 114);
            button1.Name = "button1";
            button1.Size = new Size(141, 51);
            button1.TabIndex = 0;
            button1.Text = "Факультет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(77, 193);
            button2.Name = "button2";
            button2.Size = new Size(141, 51);
            button2.TabIndex = 1;
            button2.Text = "Специальность";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(310, 26);
            label1.Name = "label1";
            label1.Size = new Size(134, 29);
            label1.TabIndex = 2;
            label1.Text = "Добавить";
            // 
            // button3
            // 
            button3.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(77, 271);
            button3.Name = "button3";
            button3.Size = new Size(141, 51);
            button3.TabIndex = 3;
            button3.Text = "Прививку";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(310, 271);
            button4.Name = "button4";
            button4.Size = new Size(141, 51);
            button4.TabIndex = 4;
            button4.Text = "Больничный";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(310, 193);
            button5.Name = "button5";
            button5.Size = new Size(141, 51);
            button5.TabIndex = 5;
            button5.Text = "Обращение в здравпункт";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(310, 114);
            button6.Name = "button6";
            button6.Size = new Size(141, 51);
            button6.TabIndex = 6;
            button6.Text = "Врача";
            button6.UseVisualStyleBackColor = true;
            button6.Click += toAddDoctorForm;
            // 
            // button7
            // 
            button7.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(539, 114);
            button7.Name = "button7";
            button7.Size = new Size(141, 51);
            button7.TabIndex = 7;
            button7.Text = "Медосмотр";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.Location = new Point(539, 193);
            button8.Name = "button8";
            button8.Size = new Size(141, 51);
            button8.TabIndex = 8;
            button8.Text = "Справку";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(539, 271);
            button9.Name = "button9";
            button9.Size = new Size(141, 51);
            button9.TabIndex = 9;
            button9.Text = "Болезнь";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button10.Location = new Point(12, 12);
            button10.Name = "button10";
            button10.Size = new Size(75, 23);
            button10.TabIndex = 10;
            button10.Text = "Назад";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // PastRootForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(797, 459);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PastRootForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PastRootForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}