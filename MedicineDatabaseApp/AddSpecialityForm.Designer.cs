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
            label4 = new Label();
            specialityTextBox = new TextBox();
            back_to_main_button = new Button();
            saveSpeciality = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(65, 367);
            label4.Name = "label4";
            label4.Size = new Size(203, 35);
            label4.TabIndex = 43;
            label4.Text = "Специальность";
            // 
            // specialityTextBox
            // 
            specialityTextBox.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            specialityTextBox.Location = new Point(462, 375);
            specialityTextBox.Name = "specialityTextBox";
            specialityTextBox.Size = new Size(397, 26);
            specialityTextBox.TabIndex = 44;
            // 
            // back_to_main_button
            // 
            back_to_main_button.Location = new Point(65, 724);
            back_to_main_button.Name = "back_to_main_button";
            back_to_main_button.Size = new Size(197, 57);
            back_to_main_button.TabIndex = 47;
            back_to_main_button.Text = "Назад";
            back_to_main_button.UseVisualStyleBackColor = true;
            back_to_main_button.Click += back_to_main_button_Click;
            // 
            // saveSpeciality
            // 
            saveSpeciality.Location = new Point(662, 724);
            saveSpeciality.Name = "saveSpeciality";
            saveSpeciality.Size = new Size(197, 57);
            saveSpeciality.TabIndex = 48;
            saveSpeciality.Text = "Сохранить";
            saveSpeciality.UseVisualStyleBackColor = true;
            saveSpeciality.Click += saveSpeciality_Click;
            // 
            // AddSpecialityForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(939, 865);
            Controls.Add(saveSpeciality);
            Controls.Add(back_to_main_button);
            Controls.Add(specialityTextBox);
            Controls.Add(label4);
            Name = "AddSpecialityForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddSpecialityForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox specialityTextBox;
        private Button back_to_main_button;
        private Button saveSpeciality;
    }
}