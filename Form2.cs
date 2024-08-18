using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int aa = int.Parse(Tid.Text);
            String bb = Tname.Text;
            String cc = Tpassword.Text;
            String dd = Temail.Text;
            String ff = Taddress.Text;

            SqlConnection con;

            String connect = @"Data Source=DESKTOP-TAUMUDG\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";

            con = new SqlConnection(connect);
            con.Open();
            Console.WriteLine("Connection establishes successfully...!");

            String query = "insert into Teacher(t_id,t_name,t_password,t_email,t_address) values('" + aa + "','" + bb + "','" + cc + "','" + dd + "','" + ff + "')";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            Console.WriteLine("Your registration is done...!");

            Tid.Text = "";
            Tname.Text = "";
            Tpassword.Text = "";
            Temail.Text = "";
            Taddress.Text = "";
            con.Close();

        }

        private void Sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
