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
            back_to_main_button = new Button();
            button1 = new Button();
            SuspendLayout();
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
            // AddIllnessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(939, 545);
            Controls.Add(button1);
            Controls.Add(back_to_main_button);
            Name = "AddIllnessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddIllnessForm";
            ResumeLayout(false);
        }

        #endregion
        private Button back_to_main_button;
        private Button button1;
    }
}