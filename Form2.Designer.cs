namespace StudentManagementSystem
{
    partial class Form2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            Tid = new TextBox();
            Tname = new TextBox();
            Tpassword = new TextBox();
            Temail = new TextBox();
            Taddress = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(284, 21);
            label1.Name = "label1";
            label1.Size = new Size(124, 35);
            label1.TabIndex = 0;
            label1.Text = "Sign Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(127, 135);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 1;
            label2.Text = "Teacher Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 160);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(127, 85);
            label4.Name = "label4";
            label4.Size = new Size(117, 29);
            label4.TabIndex = 3;
            label4.Text = "Teacher ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(127, 243);
            label5.Name = "label5";
            label5.Size = new Size(178, 29);
            label5.TabIndex = 4;
            label5.Text = "Teacher Email ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(122, 299);
            label6.Name = "label6";
            label6.Size = new Size(183, 29);
            label6.TabIndex = 5;
            label6.Text = " Teacher Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(122, 195);
            label7.Name = "label7";
            label7.Size = new Size(194, 29);
            label7.TabIndex = 3;
            label7.Text = "Teacher Password";
            // 
            // Tid
            // 
            Tid.Location = new Point(343, 83);
            Tid.Name = "Tid";
            Tid.Size = new Size(200, 31);
            Tid.TabIndex = 6;
            Tid.TextChanged += Sid_TextChanged;
            // 
            // Tname
            // 
            Tname.Location = new Point(343, 133);
            Tname.Name = "Tname";
            Tname.Size = new Size(200, 31);
            Tname.TabIndex = 6;
            // 
            // Tpassword
            // 
            Tpassword.Location = new Point(343, 193);
            Tpassword.Name = "Tpassword";
            Tpassword.Size = new Size(200, 31);
            Tpassword.TabIndex = 6;
            // 
            // Temail
            // 
            Temail.Location = new Point(343, 241);
            Temail.Name = "Temail";
            Temail.Size = new Size(200, 31);
            Temail.TabIndex = 6;
            // 
            // Taddress
            // 
            Taddress.Location = new Point(343, 297);
            Taddress.Name = "Taddress";
            Taddress.Size = new Size(200, 31);
            Taddress.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(343, 374);
            button1.Name = "button1";
            button1.Size = new Size(184, 39);
            button1.TabIndex = 7;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Taddress);
            Controls.Add(Temail);
            Controls.Add(Tpassword);
            Controls.Add(Tname);
            Controls.Add(Tid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox Tid;
        private TextBox Tname;
        private TextBox Tpassword;
        private TextBox Temail;
        private TextBox Taddress;
        private Button button1;
    }
}