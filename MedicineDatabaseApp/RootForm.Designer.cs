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
            SuspendLayout();
            // 
            // toAddForm
            // 
            toAddForm.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAddForm.Location = new Point(219, 422);
            toAddForm.Name = "toAddForm";
            toAddForm.Size = new Size(233, 99);
            toAddForm.TabIndex = 0;
            toAddForm.Text = "Добавить студента";
            toAddForm.UseVisualStyleBackColor = true;
   
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
            overview.Location = new Point(658, 422);
            overview.Name = "overview";
            overview.Size = new Size(233, 99);
            overview.TabIndex = 2;
            overview.Text = "Просмотр студентов";
            overview.UseVisualStyleBackColor = true;
            // 
            // RootForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 686);
            Controls.Add(overview);
            Controls.Add(label1);
            Controls.Add(toAddForm);
            Name = "RootForm";
            Text = "RootForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button toAddForm;
        private Label label1;
        private Button overview;
    }
}