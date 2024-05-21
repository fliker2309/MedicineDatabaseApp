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
            button1 = new Button();
            label2 = new Label();
            studentBox = new ComboBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            typeTB = new TextBox();
            button2 = new Button();
            backBtn = new Button();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(135, 65);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 44;
            label2.Text = "Ф.И.О. пациента";
            // 
            // studentBox
            // 
            studentBox.FormattingEnabled = true;
            studentBox.Location = new Point(401, 66);
            studentBox.Name = "studentBox";
            studentBox.Size = new Size(229, 23);
            studentBox.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(135, 134);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 47;
            label1.Text = "Тип болезни";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(401, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 23);
            comboBox1.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(135, 203);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 49;
            label3.Text = "Название болезни";
            // 
            // typeTB
            // 
            typeTB.Location = new Point(401, 204);
            typeTB.Margin = new Padding(4);
            typeTB.Name = "typeTB";
            typeTB.Size = new Size(229, 23);
            typeTB.TabIndex = 50;
            // 
            // button2
            // 
            button2.Location = new Point(578, 325);
            button2.Name = "button2";
            button2.Size = new Size(145, 56);
            button2.TabIndex = 51;
            button2.Text = "Добавить запись в медкарту";
            button2.UseVisualStyleBackColor = true;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(135, 325);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(136, 56);
            backBtn.TabIndex = 52;
            backBtn.Text = "Назад";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += button3_Click;
            // 
            // AddIllnessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(830, 450);
            Controls.Add(backBtn);
            Controls.Add(button2);
            Controls.Add(typeTB);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(studentBox);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "AddIllnessForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddIllnessForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Label label2;
        private ComboBox studentBox;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox typeTB;
        private Button button2;
        private Button backBtn;
    }
}