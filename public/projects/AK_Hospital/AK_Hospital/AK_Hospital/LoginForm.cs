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

namespace AK_Hospital
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection con;
        string str = "Data Source=DESKTOP-419FL1G\\SQLEXPRESS;Initial Catalog= AKHospital; Integrated Security = true;";

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(str)) 
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter("CheckLogin", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Username", username.Text);
                    da.SelectCommand.Parameters.AddWithValue("@Password", password.Text);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        SqlCommand cmd = new SqlCommand("Login", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Username", username.Text);


                        cmd.ExecuteNonQuery();

                        MainForm form1 = new MainForm();
                        this.Hide();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Login credentials","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            username.Text = "DagmawiNapoleon";
            password.Text = "1234";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
