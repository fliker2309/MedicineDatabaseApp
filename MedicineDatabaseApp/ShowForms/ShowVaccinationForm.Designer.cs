namespace MedicineDatabaseApp.ShowForms
{
    partial class ShowVaccinationForm
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
            listView1 = new ListView();
            label1 = new Label();
            backBtn = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(109, 122);
            listView1.Name = "listView1";
            listView1.Size = new Size(590, 278);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(245, 28);
            label1.Name = "label1";
            label1.Size = new Size(319, 31);
            label1.TabIndex = 1;
            label1.Text = "Список прививок студента";
            // 
            // backBtn
            // 
            backBtn.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic);
            backBtn.Location = new Point(27, 526);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(197, 57);
            backBtn.TabIndex = 22;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // ShowVaccinationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(843, 616);
            Controls.Add(backBtn);
            Controls.Add(label1);
            Controls.Add(listView1);
            Name = "ShowVaccinationForm";
            Text = "ShowVaccinationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private Button backBtn;
    }
}