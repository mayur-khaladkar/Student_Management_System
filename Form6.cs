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
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Did.Text;

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-TAUMUDG\\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True");
            conn.Open();

            string sql = "delete from Student where s_id=@id";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", a);

            int status = cmd.ExecuteNonQuery();
            if (status != 0)
            {
                MessageBox.Show("data deleted successfully ", "sucess");
            }
            else
            {
                MessageBox.Show("no recorded will be found ", "error");
            }

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
