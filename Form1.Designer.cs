namespace StudentManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            name = new TextBox();
            password = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(152, 127);
            label1.Name = "label1";
            label1.Size = new Size(73, 29);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 175);
            label2.Name = "label2";
            label2.Size = new Size(111, 29);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 44);
            label3.Name = "label3";
            label3.Size = new Size(138, 35);
            label3.TabIndex = 2;
            label3.Text = "Login Page";
            // 
            // name
            // 
            name.Location = new Point(288, 121);
            name.Name = "name";
            name.Size = new Size(277, 31);
            name.TabIndex = 3;
            name.Text = "R";
            name.TextChanged += name_TextChanged;
            // 
            // password
            // 
            password.Location = new Point(288, 173);
            password.Name = "password";
            password.Size = new Size(277, 31);
            password.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(176, 275);
            button1.Name = "button1";
            button1.Size = new Size(177, 34);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DeepSkyBlue;
            button2.Location = new Point(440, 275);
            button2.Name = "button2";
            button2.Size = new Size(187, 34);
            button2.TabIndex = 6;
            button2.Text = "Create Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox name;
        private TextBox password;
        private Button button1;
        private Button button2;
    }
}
