namespace MedicineDatabaseApp
{
    partial class RootForm
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
            toAddForm = new Button();
            label1 = new Label();
            overview = new Button();
            toCardAddForm = new Button();
            toAddChechupForm = new Button();
            toAddIllnessForm = new Button();
            toAddCertificateForm = new Button();
            closeAppBtn = new Button();
            SuspendLayout();
            // 
            // toAddForm
            // 
            toAddForm.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAddForm.Location = new Point(114, 197);
            toAddForm.Name = "toAddForm";
            toAddForm.Size = new Size(233, 99);
            toAddForm.TabIndex = 0;
            toAddForm.Text = "Добавить студента";
            toAddForm.UseVisualStyleBackColor = true;
            toAddForm.Click += toAddForm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 54);
            label1.Name = "label1";
            label1.Size = new Size(672, 61);
            label1.TabIndex = 1;
            label1.Text = "База данных студентов ПГУ";
            // 
            // overview
            // 
            overview.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            overview.Location = new Point(490, 373);
            overview.Name = "overview";
            overview.Size = new Size(233, 99);
            overview.TabIndex = 2;
            overview.Text = "Просмотр студентов";
            overview.UseVisualStyleBackColor = true;
            // 
            // toCardAddForm
            // 
            toCardAddForm.Font = new Font("Trebuchet MS", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toCardAddForm.Location = new Point(114, 373);
            toCardAddForm.Name = "toCardAddForm";
            toCardAddForm.Size = new Size(233, 99);
            toCardAddForm.TabIndex = 3;
            toCardAddForm.Text = "Добавить медкарту";
            toCardAddForm.UseVisualStyleBackColor = true;
            toCardAddForm.Click += button1_Click;
            // 
            // toAddChechupForm
            // 
            toAddChechupForm.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAddChechupForm.Location = new Point(114, 545);
            toAddChechupForm.Name = "toAddChechupForm";
            toAddChechupForm.Size = new Size(233, 99);
            toAddChechupForm.TabIndex = 4;
            toAddChechupForm.Text = "Добавить медосмотр";
            toAddChechupForm.UseVisualStyleBackColor = true;
            toAddChechupForm.Click += toAddChechupForm_Click;
            // 
            // toAddIllnessForm
            // 
            toAddIllnessForm.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAddIllnessForm.Location = new Point(827, 197);
            toAddIllnessForm.Name = "toAddIllnessForm";
            toAddIllnessForm.Size = new Size(233, 99);
            toAddIllnessForm.TabIndex = 5;
            toAddIllnessForm.Text = "Добавить заболевание";
            toAddIllnessForm.UseVisualStyleBackColor = true;
            toAddIllnessForm.Click += toAddIllnessForm_Click;
            // 
            // toAddCertificateForm
            // 
            toAddCertificateForm.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAddCertificateForm.Location = new Point(827, 545);
            toAddCertificateForm.Name = "toAddCertificateForm";
            toAddCertificateForm.Size = new Size(233, 99);
            toAddCertificateForm.TabIndex = 6;
            toAddCertificateForm.Text = "Добавить справку";
            toAddCertificateForm.UseVisualStyleBackColor = true;
            // 
            // closeAppBtn
            // 
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.Location = new Point(1071, 12);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(75, 32);
            closeAppBtn.TabIndex = 7;
            closeAppBtn.Text = "Выход";
            closeAppBtn.UseVisualStyleBackColor = true;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // RootForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 686);
            Controls.Add(closeAppBtn);
            Controls.Add(toAddCertificateForm);
            Controls.Add(toAddIllnessForm);
            Controls.Add(toAddChechupForm);
            Controls.Add(toCardAddForm);
            Controls.Add(overview);
            Controls.Add(label1);
            Controls.Add(toAddForm);
            Name = "RootForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RootForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toAddForm;
        private Label label1;
        private Button overview;
        private Button toCardAddForm;
        private Button toAddChechupForm;
        private Button toAddIllnessForm;
        private Button toAddCertificateForm;
        private Button closeAppBtn;
    }
}