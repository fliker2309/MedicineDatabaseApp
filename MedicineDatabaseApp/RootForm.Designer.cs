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
            label1 = new Label();
            closeAppBtn = new Button();
            toSearchWithParameters = new Button();
            toAddForm = new Button();
            toAddIllnessForm = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 59);
            label1.Name = "label1";
            label1.Size = new Size(672, 61);
            label1.TabIndex = 1;
            label1.Text = "База данных студентов ПГУ";
            // 
            // closeAppBtn
            // 
            closeAppBtn.BackColor = Color.Salmon;
            closeAppBtn.Cursor = Cursors.Hand;
            closeAppBtn.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            closeAppBtn.ForeColor = SystemColors.ButtonHighlight;
            closeAppBtn.Location = new Point(894, 3);
            closeAppBtn.Name = "closeAppBtn";
            closeAppBtn.Size = new Size(33, 32);
            closeAppBtn.TabIndex = 7;
            closeAppBtn.Text = "X";
            closeAppBtn.UseVisualStyleBackColor = false;
            closeAppBtn.Click += closeAppBtn_Click;
            // 
            // toSearchWithParameters
            // 
            toSearchWithParameters.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toSearchWithParameters.Location = new Point(346, 212);
            toSearchWithParameters.Name = "toSearchWithParameters";
            toSearchWithParameters.Size = new Size(233, 99);
            toSearchWithParameters.TabIndex = 10;
            toSearchWithParameters.Text = "Просмотр студентов";
            toSearchWithParameters.UseVisualStyleBackColor = true;
            toSearchWithParameters.Click += toSearchWithParameters_Click;
            // 
            // toAddForm
            // 
            toAddForm.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAddForm.Location = new Point(34, 212);
            toAddForm.Name = "toAddForm";
            toAddForm.Size = new Size(233, 99);
            toAddForm.TabIndex = 0;
            toAddForm.Text = "Добавить студента";
            toAddForm.UseVisualStyleBackColor = true;
            toAddForm.Click += toAddForm_Click;
            // 
            // toAddIllnessForm
            // 
            toAddIllnessForm.Font = new Font("Trebuchet MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toAddIllnessForm.Location = new Point(658, 212);
            toAddIllnessForm.Name = "toAddIllnessForm";
            toAddIllnessForm.Size = new Size(233, 99);
            toAddIllnessForm.TabIndex = 5;
            toAddIllnessForm.Text = "Добавить информацию";
            toAddIllnessForm.UseVisualStyleBackColor = true;
            toAddIllnessForm.Click += toPastRootForm;
            // 
            // RootForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(929, 512);
            ControlBox = false;
            Controls.Add(toSearchWithParameters);
            Controls.Add(closeAppBtn);
            Controls.Add(toAddIllnessForm);
            Controls.Add(label1);
            Controls.Add(toAddForm);
            Name = "RootForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RootForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button closeAppBtn;
        private Button toSearchWithParameters;
        private Button toAddForm;
        private Button toAddIllnessForm;
    }
}