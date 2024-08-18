using System.Data.SqlClient;

namespace StudentManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Mask the password input with '*'
            password.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = name.Text;
            string b = password.Text;
            SqlConnection con;

            string connect = @"Data Source=DESKTOP-TAUMUDG\SQLEXPRESS;Initial Catalog=StudentManagement;Integrated Security=True";
            con = new SqlConnection(connect);

            con.Open();

            string query = "SELECT t_name, t_password FROM Teacher";

            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string Mname = reader.GetString(reader.GetOrdinal("t_name"));
                    string Mpass = reader.GetString(reader.GetOrdinal("t_password"));

                    if (a == Mname && b == Mpass)
                    {
                        this.Hide();
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid details", "Error");
            }
            name.Text = "";
            password.Text = "";
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
