namespace StudentManagementSystem
{
    partial class Form5
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
            Uid = new TextBox();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Uname = new TextBox();
            Upassword = new TextBox();
            Umail = new TextBox();
            Uaddress = new TextBox();
            label10 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(271, 19);
            label1.Name = "label1";
            label1.Size = new Size(261, 35);
            label1.TabIndex = 0;
            label1.Text = "Student Data Update";
            // 
            // Uid
            // 
            Uid.Location = new Point(301, 86);
            Uid.Name = "Uid";
            Uid.Size = new Size(209, 31);
            Uid.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(135, 92);
            label3.Name = "label3";
            label3.Size = new Size(117, 29);
            label3.TabIndex = 4;
            label3.Text = "Student ID";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(203, 389);
            button1.Name = "button1";
            button1.Size = new Size(157, 49);
            button1.TabIndex = 5;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(125, 159);
            label2.Name = "label2";
            label2.Size = new Size(156, 29);
            label2.TabIndex = 6;
            label2.Text = "Student Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(135, 218);
            label4.Name = "label4";
            label4.Size = new Size(111, 29);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(135, 276);
            label5.Name = "label5";
            label5.Size = new Size(95, 29);
            label5.TabIndex = 6;
            label5.Text = "Email ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(135, 328);
            label6.Name = "label6";
            label6.Size = new Size(95, 29);
            label6.TabIndex = 6;
            label6.Text = "Address";
            // 
            // Uname
            // 
            Uname.Location = new Point(301, 157);
            Uname.Name = "Uname";
            Uname.Size = new Size(209, 31);
            Uname.TabIndex = 3;
            // 
            // Upassword
            // 
            Upassword.Location = new Point(301, 212);
            Upassword.Name = "Upassword";
            Upassword.Size = new Size(209, 31);
            Upassword.TabIndex = 3;
            // 
            // Umail
            // 
            Umail.Location = new Point(301, 270);
            Umail.Name = "Umail";
            Umail.Size = new Size(209, 31);
            Umail.TabIndex = 3;
            // 
            // Uaddress
            // 
            Uaddress.Location = new Point(301, 326);
            Uaddress.Name = "Uaddress";
            Uaddress.Size = new Size(209, 31);
            Uaddress.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(135, 464);
            label10.Name = "label10";
            label10.Size = new Size(87, 25);
            label10.TabIndex = 6;
            label10.Text = "Password";
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(454, 389);
            button2.Name = "button2";
            button2.Size = new Size(160, 49);
            button2.TabIndex = 7;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Uaddress);
            Controls.Add(Umail);
            Controls.Add(Upassword);
            Controls.Add(Uname);
            Controls.Add(Uid);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Uid;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Uname;
        private TextBox Upassword;
        private TextBox Umail;
        private TextBox Uaddress;
        private Label label10;
        private Button button2;
    }
}