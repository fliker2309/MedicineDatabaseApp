namespace MedicineDatabaseApp
{
    partial class EditSpecialityForm
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
            SpecialityForm = new ListView();
            SpecialityTextBox = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(55, 368);
            button1.Name = "button1";
            button1.Size = new Size(119, 50);
            button1.TabIndex = 0;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(631, 368);
            button2.Name = "button2";
            button2.Size = new Size(123, 50);
            button2.TabIndex = 1;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(344, 368);
            button3.Name = "button3";
            button3.Size = new Size(123, 50);
            button3.TabIndex = 2;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(55, 84);
            label1.Name = "label1";
            label1.Size = new Size(248, 36);
            label1.TabIndex = 3;
            label1.Text = "Специальность:";
            // 
            // SpecialityForm
            // 
            SpecialityForm.Font = new Font("Times New Roman", 14.25F);
            SpecialityForm.Location = new Point(55, 139);
            SpecialityForm.Name = "SpecialityForm";
            SpecialityForm.Size = new Size(699, 223);
            SpecialityForm.TabIndex = 4;
            SpecialityForm.UseCompatibleStateImageBehavior = false;
            // 
            // SpecialityTextBox
            // 
            SpecialityTextBox.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SpecialityTextBox.Location = new Point(299, 91);
            SpecialityTextBox.Name = "SpecialityTextBox";
            SpecialityTextBox.Size = new Size(455, 29);
            SpecialityTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(33, 26);
            label2.Name = "label2";
            label2.Size = new Size(753, 36);
            label2.TabIndex = 6;
            label2.Text = "Форма редактирования и удаления специальностей";
            // 
            // EditSpecialityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(SpecialityTextBox);
            Controls.Add(SpecialityForm);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EditSpecialityForm";
            Text = "EditSpecialityForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private ListView SpecialityForm;
        private TextBox SpecialityTextBox;
        private Label label2;
    }
}