using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = Uid.Text;
            String b = Uname.Text;
            String c = Upassword.Text;
            String d = Umail.Text;
            String f = Uaddress.Text;


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-TAUMUDG\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True");

            con.Open();


            String sql = "update  Student set s_name=@nm,s_password=@pw,s_email=@em,s_address=@adr where s_id=@id";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@nm", b);
            cmd.Parameters.AddWithValue("@pw", c);
            cmd.Parameters.AddWithValue("@em", d);
            cmd.Parameters.AddWithValue("@adr", f);
            cmd.Parameters.AddWithValue("@id", a);

            int count = cmd.ExecuteNonQuery();

            if (count != 0)
            {
                MessageBox.Show("data updated successfully");
            }
            else
            {
                MessageBox.Show("Invalid ID please check it once");
            }

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
