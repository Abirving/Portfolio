using AK_Hospital.Domain_Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AK_Hospital.User_Controls
{
    public partial class StaffControl : UserControl
    {
        public StaffControl()
        {
            InitializeComponent();
        }

        public int counter = 0;

        private void addStaff_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(staffId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(firstname.Text))
            {  
                error2.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(lastname.Text))
            {
                error3.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(username.Text))
            {
                error4.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(pass.Text))
            {
                error5.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(confirm.Text))
            {
                error6.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }


            if (!(pass.Text).Equals(confirm.Text))
            {
                MessageBox.Show("Password must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                staffId.Focus();
                return;
            }

            string role;
            if (admin.Checked)
                role = "Admin";
            else if (surgeon.Checked)
                role = "Surgeon";
            else
                role = "Nurse";



            Staff s = new Staff()
            {
                StaffId = int.Parse(staffId.Text),
                FirstName = firstname.Text,
                LastName = lastname.Text,
                Username = username.Text,
                Password = pass.Text,
                Role = role,
            };

            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.saveStaff(s);
        }

        private void updateStaff_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(staffId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(firstname.Text))
            {
                error2.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(lastname.Text))
            {
                error3.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(username.Text))
            {
                error4.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(pass.Text))
            {
                error5.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(confirm.Text))
            {
                error6.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }


            if (!(pass.Text).Equals(confirm.Text))
            {
                MessageBox.Show("Password must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                staffId.Focus();
                return;
            }

            string role;
            if (admin.Checked)
                role = "Admin";
            else if (surgeon.Checked)
                role = "Surgeon";
            else
                role = "Nurse";



            Staff s = new Staff()
            {
                StaffId = int.Parse(staffId.Text),
                FirstName = firstname.Text,
                LastName = lastname.Text,
                Username = username.Text,
                Password = pass.Text,
                Role = role,
            };
            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.updateStaff(s);
        }

        private void deleteStaff_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(staffId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }


            string role;
            if (admin.Checked)
                role = "Admin";
            else if (surgeon.Checked)
                role = "Surgeon";
            else
                role = "Nurse";



            int id = int.Parse(staffId.Text);
            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.deleteStaff(id);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            staffId.Clear();
            firstname.Clear();
            lastname.Clear();
            username.Clear();
            pass.Clear();
            confirm.Clear();
            admin.Checked = false;
            surgeon.Checked = false;
            nurse.Checked = false;
            staffId.Focus();
        }

        private void StaffControl_Load(object sender, EventArgs e)
        {
            updater.Start();
            SqlConnection con;
            string str = "Data Source=DESKTOP-419FL1G\\SQLEXPRESS;Initial Catalog= AKHospital; Integrated Security = true;";

            using (con = new SqlConnection(str))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select Role from Staff where Logged = 1", con);
                    cmd.CommandType = CommandType.Text;

                    string Role = (string)cmd.ExecuteScalar();
                    if (!(Role.Equals("Admin")))
                    {
                        Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Hide()
        {
            gunaLabel1.Visible = false;
            gunaLabel2.Visible = false;
            gunaLabel3.Visible = false;
            gunaLabel4.Visible = false;
            gunaLabel5.Visible = false;
            gunaLabel6.Visible = false;
            gunaLabel7.Visible = false;
            gunaLabel8.Visible = false;
            staffId.Visible = false;
            firstname.Visible = false;
            lastname.Visible = false;
            username.Visible = false;
            pass.Visible = false;
            confirm.Visible = false;
            admin.Visible = false;
            surgeon.Visible = false;
            nurse.Visible = false;
            addStaff.Visible = false;
            updateStaff.Visible = false;
            deleteStaff.Visible = false;
            clear.Visible = false;
            dgv.Width = 1235;
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            if (allRecord.Checked)
            {
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.getStaff().Tables["Staff"];
            }
            else if (admins.Checked)
            {
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.getAdmins().Tables["Admins"];
            }
            else if (surgeons.Checked)
            {
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.getSurgeons().Tables["Surgeons"];
            }
            else if (nurses.Checked)
            {
                ThirdLayer tl = new ThirdLayer();
                dgv.DataSource = tl.getNurses().Tables["Nurses"];
            }
        }

        private void errorDisplay_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 1)
            {
                counter = 0;
                errorDisplay.Stop();
                error1.Visible = false;
                error2.Visible = false;
                error3.Visible = false;
                error4.Visible = false;
                error5.Visible = false;
                error6.Visible = false;
            }
        }

        private void error1_Click(object sender, EventArgs e)
        {

        }

        private void admins_Click(object sender, EventArgs e)
        {

        }
    }
}
