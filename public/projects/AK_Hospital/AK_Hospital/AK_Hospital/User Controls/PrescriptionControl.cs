using AK_Hospital.Domain_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_Hospital.User_Controls
{
    public partial class PrescriptionControl : UserControl
    {
        public PrescriptionControl()
        {
            InitializeComponent();
        }

        public int counter = 0;

        private void addPrescription_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(preId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(patId.Text))
            {
                error2.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(medId.Text))
            {
                error3.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }


            Prescriptions p = new Prescriptions()
            {
                PrescriptionId = int.Parse(preId.Text),
                PatientId = int.Parse(patId.Text),
                MedicationId = int.Parse(medId.Text),
            };
            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.savePrescription(p);
        }

        private void updatePrescription_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(preId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(patId.Text))
            {
                error2.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(medId.Text))
            {
                error3.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }


            Prescriptions p = new Prescriptions()
            {
                PrescriptionId = int.Parse(preId.Text),
                PatientId = int.Parse(patId.Text),
                MedicationId = int.Parse(medId.Text),
            };
            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.updatePrescription(p);
        }

        private void deletePrescription_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(preId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }

            int send = int.Parse(preId.Text);
            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.deletePrescription(send);
        }

        private void PrescriptionControl_Load(object sender, EventArgs e)
        {
            updater.Start();
            PatientUpdater.Start();
            MedUpdater.Start();
            string str = "Data Source=DESKTOP-419FL1G\\SQLEXPRESS;Initial Catalog= AKHospital; Integrated Security = true;";



            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Role from Staff where Logged = 1", con);
                    string role = (String)cmd.ExecuteScalar();

                    if (role.Equals("Nurse"))
                    {
                        dgv.Width = 1235;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            ThirdLayer tl = new ThirdLayer();
            dgv.DataSource = tl.getPrescription().Tables["Prescription"];
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
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            preId.Clear();
            patId.Clear();
            medId.Clear();
            preId.Focus();
        }

        private void PatientUpdater_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(patId.Text))
                return;
            ThirdLayer tl = new ThirdLayer();
            patientName.Text = tl.getPatientName(int.Parse(patId.Text));
        }

        private void MedUpdater_Tick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(medId.Text))
                return;

            ThirdLayer tl = new ThirdLayer();
            medicationName.Text = tl.getMedicationName(int.Parse(medId.Text));
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
