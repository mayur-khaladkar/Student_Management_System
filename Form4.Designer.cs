namespace StudentManagementSystem
{
    partial class Form4
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
            Sid = new TextBox();
            Sname = new TextBox();
            Spassword = new TextBox();
            Semail = new TextBox();
            Saddress = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 36);
            label1.Name = "label1";
            label1.Size = new Size(183, 35);
            label1.TabIndex = 0;
            label1.Text = "Student Detail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(166, 99);
            label2.Name = "label2";
            label2.Size = new Size(117, 29);
            label2.TabIndex = 1;
            label2.Text = "Student ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 156);
            label3.Name = "label3";
            label3.Size = new Size(156, 29);
            label3.TabIndex = 1;
            label3.Text = "Student Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(166, 213);
            label4.Name = "label4";
            label4.Size = new Size(111, 29);
            label4.TabIndex = 1;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(166, 261);
            label5.Name = "label5";
            label5.Size = new Size(95, 29);
            label5.TabIndex = 1;
            label5.Text = "Email ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(166, 314);
            label6.Name = "label6";
            label6.Size = new Size(95, 29);
            label6.TabIndex = 1;
            label6.Text = "Address";
            // 
            // Sid
            // 
            Sid.Location = new Point(299, 96);
            Sid.Name = "Sid";
            Sid.Size = new Size(251, 31);
            Sid.TabIndex = 2;
            // 
            // Sname
            // 
            Sname.Location = new Point(299, 154);
            Sname.Name = "Sname";
            Sname.Size = new Size(251, 31);
            Sname.TabIndex = 2;
            // 
            // Spassword
            // 
            Spassword.Location = new Point(299, 207);
            Spassword.Name = "Spassword";
            Spassword.Size = new Size(251, 31);
            Spassword.TabIndex = 2;
            // 
            // Semail
            // 
            Semail.Location = new Point(299, 255);
            Semail.Name = "Semail";
            Semail.Size = new Size(251, 31);
            Semail.TabIndex = 2;
            // 
            // Saddress
            // 
            Saddress.Location = new Point(299, 308);
            Saddress.Name = "Saddress";
            Saddress.Size = new Size(251, 31);
            Saddress.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(197, 395);
            button1.Name = "button1";
            button1.Size = new Size(155, 43);
            button1.TabIndex = 3;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(446, 395);
            button2.Name = "button2";
            button2.Size = new Size(170, 43);
            button2.TabIndex = 4;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Saddress);
            Controls.Add(Semail);
            Controls.Add(Spassword);
            Controls.Add(Sname);
            Controls.Add(Sid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
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
        private TextBox Sid;
        private TextBox Sname;
        private TextBox Spassword;
        private TextBox Semail;
        private TextBox Saddress;
        private Button button1;
        private Button button2;
    }
}