namespace MedicineDatabaseApp
{
    partial class ShowCardForm
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 65);
            label1.Name = "label1";
            label1.Size = new Size(410, 21);
            label1.TabIndex = 0;
            label1.Text = "ФАМИЛИЯ ИМЯ ОТЧЕСТВО";
            // 
            // ShowCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(970, 758);
            ControlBox = false;
            Controls.Add(label1);
            Name = "ShowCardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowCardForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}