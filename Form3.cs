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
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.ShowDialog();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con;

            string connect = @"Data Source=DESKTOP-TAUMUDG\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";
            con = new SqlConnection(connect);

            con.Open();

            string query = "select * from Student";

            SqlCommand sqlCommand = new SqlCommand(query, con);
            SqlDataReader r = sqlCommand.ExecuteReader();

            if (r.HasRows)
            {
                StringBuilder data = new StringBuilder();
                while (r.Read())
                {
                    int id = (r.GetInt32(r.GetOrdinal("s_id")));
                    string name = r.GetString(r.GetOrdinal("s_name"));
                    string email = r.GetString(r.GetOrdinal("s_email"));
                    string password = r.GetString(r.GetOrdinal("s_password"));
                    string address = r.GetString(r.GetOrdinal("s_address"));

                    data.Append($"s_id:{id},s_name:{name},s_password:{password},s_email:{email},s_address:{address}");


                }
                MessageBox.Show(data.ToString(), "Add data");
            }
            r.Close();
            con.Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
    }
}
