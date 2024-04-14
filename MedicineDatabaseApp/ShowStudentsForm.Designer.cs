namespace MedicineDatabaseApp
{
    partial class ShowStudentsForm
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
            studentsDataGridView = new DataGridView();
            toMenuButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // studentsDataGridView
            // 
            studentsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsDataGridView.Location = new Point(121, 270);
            studentsDataGridView.Name = "studentsDataGridView";
            studentsDataGridView.Size = new Size(731, 166);
            studentsDataGridView.TabIndex = 0;
            // 
            // toMenuButton
            // 
            toMenuButton.Location = new Point(195, 734);
            toMenuButton.Name = "toMenuButton";
            toMenuButton.Size = new Size(241, 93);
            toMenuButton.TabIndex = 1;
            toMenuButton.Text = "button1";
            toMenuButton.UseVisualStyleBackColor = true;
            toMenuButton.Click += toMenuButton_Click;
            // 
            // ShowStudentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 888);
            Controls.Add(toMenuButton);
            Controls.Add(studentsDataGridView);
            Name = "ShowStudentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShowStudents";
            ((System.ComponentModel.ISupportInitialize)studentsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView studentsDataGridView;
        private Button toMenuButton;
    }
}