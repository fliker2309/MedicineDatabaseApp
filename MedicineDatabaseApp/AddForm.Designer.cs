namespace MedicineDatabaseApp
{
    partial class AddForm
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
            surname_label = new Label();
            name_label = new Label();
            lastname_label = new Label();
            SuspendLayout();
            // 
            // surname_label
            // 
            surname_label.AutoSize = true;
            surname_label.Location = new Point(327, 159);
            surname_label.Name = "surname_label";
            surname_label.Size = new Size(58, 15);
            surname_label.TabIndex = 0;
            surname_label.Text = "Фамилия";
            // 
            // name_label
            // 
            name_label.AutoSize = true;
            name_label.Location = new Point(327, 207);
            name_label.Name = "name_label";
            name_label.Size = new Size(31, 15);
            name_label.TabIndex = 1;
            name_label.Text = "Имя";
            // 
            // lastname_label
            // 
            lastname_label.AutoSize = true;
            lastname_label.Location = new Point(327, 259);
            lastname_label.Name = "lastname_label";
            lastname_label.Size = new Size(58, 15);
            lastname_label.TabIndex = 2;
            lastname_label.Text = "Отчество";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 873);
            Controls.Add(lastname_label);
            Controls.Add(name_label);
            Controls.Add(surname_label);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label surname_label;
        private Label name_label;
        private Label lastname_label;
    }
}