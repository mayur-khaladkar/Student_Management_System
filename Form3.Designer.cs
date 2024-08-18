namespace StudentManagementSystem
{
    partial class Form3
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
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Plum;
            label1.Font = new Font("Calibri", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 29);
            label1.Name = "label1";
            label1.Size = new Size(281, 68);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(101, 293);
            button1.Name = "button1";
            button1.Size = new Size(112, 52);
            button1.TabIndex = 1;
            button1.Text = "Insertion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DodgerBlue;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(437, 293);
            button3.Name = "button3";
            button3.Size = new Size(122, 52);
            button3.TabIndex = 2;
            button3.Text = "Updation";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DodgerBlue;
            button4.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(608, 293);
            button4.Name = "button4";
            button4.Size = new Size(112, 52);
            button4.TabIndex = 3;
            button4.Text = "Deletion";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DodgerBlue;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(275, 293);
            button2.Name = "button2";
            button2.Size = new Size(112, 52);
            button2.TabIndex = 4;
            button2.Text = "Retrieve";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Ivory;
            textBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.MidnightBlue;
            textBox1.Location = new Point(75, 153);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(618, 77);
            textBox1.TabIndex = 5;
            textBox1.Text = "\"Click the button that matches your choice to seamlessly complete the task and achieve your goal!\" ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private TextBox textBox1;
    }
}