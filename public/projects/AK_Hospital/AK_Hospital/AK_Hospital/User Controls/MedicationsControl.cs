using AK_Hospital.Domain_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AK_Hospital.User_Controls
{
    public partial class MedicationsControl : UserControl
    {
        public MedicationsControl()
        {
            InitializeComponent();
        }

        public int counter = 0;


        private void addMedication_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(medId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(medName.Text))
            {
                error2.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }


            Medications m = new Medications()
            {
                Medicationid = int.Parse(medId.Text),
                MedicationName = medName.Text,
                PrescribedFor = prescribedFor.Text,
            };
            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.saveMedication(m);
        }

        private void updateMedication_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(medId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }
            if (String.IsNullOrEmpty(medName.Text))
            {
                error2.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }


            Medications m = new Medications()
            {
                Medicationid = int.Parse(medId.Text),
                MedicationName = medName.Text,
                PrescribedFor = prescribedFor.Text,
            };
            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.updateMedication(m);
        }

        private void deleteMedication_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(medId.Text))
            {
                error1.Visible = true;
                MessageBox.Show("Please Insert Required Values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorDisplay.Start();
                return;
            }


            int send = int.Parse(medId.Text);
            ThirdLayer tl = new ThirdLayer();
            clear.PerformClick();
            tl.deleteMedication(send);
        }

        private void updater_Tick(object sender, EventArgs e)
        {
            ThirdLayer tl = new ThirdLayer();
            dgv.DataSource = tl.getMedication().Tables["Medications"];
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
            }
        }

        private void MedicationsControl_Load(object sender, EventArgs e)
        {
            updater.Start();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            medId.Clear();
            medName.Clear();
            prescribedFor.Clear();
            medId.Focus();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
