using AK_Hospital.User_Controls;
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

namespace AK_Hospital
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        bool is_Checked = false;


        private void Form1_Load(object sender, EventArgs e)
        {

            HomeButton.PerformClick();

            

            SqlConnection con;
            string str = "Data Source=DESKTOP-419FL1G\\SQLEXPRESS;Initial Catalog= AKHospital; Integrated Security = true;";

            using (con = new SqlConnection(str))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select username from Staff where Logged = 1", con);
                    cmd.CommandType = CommandType.Text;

                    string user = (string)cmd.ExecuteScalar();
                    ProfileButton.Text = user;

                    //..
                    //..

                    cmd = new SqlCommand("select Role from Staff where Logged = 1", con);
                    cmd.CommandType = CommandType.Text;

                    string Role = (string)cmd.ExecuteScalar();
                    if (!(Role.Equals("Admin")))
                    {
                        MedicButton.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            new ThirdLayer().logout();
            Application.Exit();
        }

        private void addUserControl(UserControl userControl)
        {
            //MainPanel.Controls.Clear();
            MainPanel.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.BringToFront();
            dragControl.TargetControl = userControl;
        }

        private void PatientsButton_Click(object sender, EventArgs e)
        {
            PatientsControl patientsControl = new PatientsControl();
            addUserControl(patientsControl);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            HomeControl homeControl = new HomeControl();
            addUserControl(homeControl);
        }

        private void MedicButton_Click(object sender, EventArgs e)
        {
            MedicationsControl medicationsControl = new MedicationsControl();
            addUserControl(medicationsControl);
        }

        private void PresButton_Click(object sender, EventArgs e)
        {
            PrescriptionControl prescriptionControl = new PrescriptionControl();
            addUserControl(prescriptionControl);
        }

        private void StaffButton_Click(object sender, EventArgs e)
        {
            StaffControl staffControl = new StaffControl();
            addUserControl(staffControl);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {

            if (!is_Checked)
            {
                is_Checked = true;
                SubMenu.Visible = true;
                SubMenu.BringToFront();
                SubMenu.Location = new Point(1039, 3);
            }
            else if (is_Checked)
            {
                is_Checked = false;
                SubMenu.Visible = false;
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to logout from " + ProfileButton.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                new ThirdLayer().logout();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to Exit", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
