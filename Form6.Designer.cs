namespace StudentManagementSystem
{
    partial class Form6
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
            label2 = new Label();
            Did = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(355, 47);
            label1.Name = "label1";
            label1.Size = new Size(180, 35);
            label1.TabIndex = 0;
            label1.Text = "Delete Record";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 174);
            label2.Name = "label2";
            label2.Size = new Size(117, 29);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // Did
            // 
            Did.Location = new Point(338, 172);
            Did.Name = "Did";
            Did.Size = new Size(212, 31);
            Did.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(250, 261);
            button1.Name = "button1";
            button1.Size = new Size(177, 51);
            button1.TabIndex = 3;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(477, 261);
            button2.Name = "button2";
            button2.Size = new Size(169, 51);
            button2.TabIndex = 4;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Did);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Did;
        private Button button1;
        private Button button2;
    }
}