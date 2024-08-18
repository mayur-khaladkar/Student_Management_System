using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentManagementSystem
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int aa = int.Parse(Sid.Text);
            String bb = Sname.Text;
            String cc = Spassword.Text;
            String dd = Semail.Text;
            String ff = Saddress.Text;

            SqlConnection con;

            String connect = @"Data Source=DESKTOP-TAUMUDG\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

            con = new SqlConnection(connect);
            con.Open();
            Console.WriteLine("Connection establishes successfully...!");

            String query = "insert into Student(s_id,s_name,s_password,s_email,s_address) values('" + aa + "','" + bb + "','" + cc + "','" + dd + "','" + ff + "')";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();



            Sid.Text = "";
            Sname.Text = "";
            Spassword.Text = "";
            Semail.Text = "";
            Saddress.Text = "";
            Console.WriteLine("Insertion done...!");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
