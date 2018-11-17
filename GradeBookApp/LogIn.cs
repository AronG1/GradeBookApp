using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GradeBookApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Focus();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtBox_Username_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "" || txtBox_Password.Text == "")
            {
                btn_Login.Enabled = false;
            }
            else
            {
                btn_Login.Enabled = true;
            }
        }

        private void txtBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "" || txtBox_Password.Text == "")
            {
                btn_Login.Enabled = false;
            }
            else
            {
                btn_Login.Enabled = true;
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {

            string connecionString = Properties.Settings.Default.StaffConnectionString;

            SqlConnection cn_connection = new SqlConnection(connecionString);

            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();
            DataTable tbl = new DataTable();
            using (SqlCommand cmd = new SqlCommand())
            {
                SqlDataReader reader;
                cmd.CommandText = "Login";
                cmd.Parameters.AddWithValue("@username", txtBox_Username.Text);
                cmd.Parameters.AddWithValue("@password", txtBox_Password.Text);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = cn_connection;


                reader = cmd.ExecuteReader();

                cn_connection.Close();

                MessageBox.Show(reader.ToString());

            }

            
        }
    }
}
