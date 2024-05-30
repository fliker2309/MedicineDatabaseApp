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
            button6 = new Button();
            button10 = new Button();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            button1.Location = new Point(74, 116);
            button1.Name = "button1";
            button1.Size = new Size(141, 51);
            button1.TabIndex = 0;
            button1.Text = "Факультет";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            button2.Location = new Point(523, 116);
            button2.Name = "button2";
            button2.Size = new Size(161, 51);
            button2.TabIndex = 1;
            button2.Text = "Специальность";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(310, 26);
            label1.Name = "label1";
            label1.Size = new Size(156, 36);
            label1.TabIndex = 2;
            label1.Text = "Добавить";
            // 
            // button6
            // 
            button6.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold);
            button6.Location = new Point(310, 116);
            button6.Name = "button6";
            button6.Size = new Size(141, 51);
            button6.TabIndex = 6;
            button6.Text = "Врача";
            button6.UseVisualStyleBackColor = true;
            button6.Click += toAddDoctorForm;
            // 
            // button10
            // 
            button10.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button10.Location = new Point(310, 233);
            button10.Name = "button10";
            button10.Size = new Size(141, 53);
            button10.TabIndex = 10;
            button10.Text = "Назад";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(760, -2);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(38, 43);
            closeAppBtn.TabIndex = 12;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            closeAppBtn.MouseLeave += closeAppBtn_MouseLeave;
            closeAppBtn.MouseHover += closeAppBtn_MouseHover;
            // 
            // PastRootForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(797, 333);
            ControlBox = false;
            Controls.Add(closeAppBtn);
            Controls.Add(button10);
            Controls.Add(button6);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PastRootForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление информации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button button6;
        private Button button10;
        private Button closeAppBtn;
    }
}