using AK_Hospital.Domain_Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AK_Hospital
{
    internal class ThirdLayer
    {

        //..
        //.. GLOBAL VARIABLES
        SqlConnection con;
        string str = "Data Source=DESKTOP-419FL1G\\SQLEXPRESS; Initial Catalog=AKHospital; Integrated Security=true;";



        //..
        //.. PATIENT MANIPULATION
        public void savePatient(Patients p)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientId", p.PatientId);
                    cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", p.LastName);
                    cmd.Parameters.AddWithValue("@Age", p.Age);
                    cmd.Parameters.AddWithValue("@Description", p.Description);
                    cmd.Parameters.AddWithValue("@PhoneNumber", p.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Status", p.Status);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Patient Saved succesfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updatePatient (Patients p)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("updateP", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientId", p.PatientId);
                    cmd.Parameters.AddWithValue("@FirstName", p.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", p.LastName);
                    cmd.Parameters.AddWithValue("@Age", p.Age);
                    cmd.Parameters.AddWithValue("@Description", p.Description);
                    cmd.Parameters.AddWithValue("@PhoneNumber", p.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Status", p.Status);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Patient Updated succesfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void activatePatient (int id, string status)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("setInactive", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientId", id);
                    cmd.Parameters.AddWithValue("@Status", status);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Patient set "+status+".", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet getPatients()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getP", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Patient");
                return ds;
            }
        }
        public DataSet getActivePatients()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getAP", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "ActivePatient");
                return ds;
            }
        }
        public DataSet getInactivePatients()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getIP", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "InactivePatient");
                return ds;
            }
        }



        //..
        //.. MEDICATION MANIPULATION
        public void saveMedication(Medications m)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MedicationId", m.Medicationid);
                    cmd.Parameters.AddWithValue("@MedicationName", m.MedicationName);
                    cmd.Parameters.AddWithValue("@PrescribedFor", m.PrescribedFor);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Medication Saved succesfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateMedication(Medications m)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("updateM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MedicationId", m.Medicationid);
                    cmd.Parameters.AddWithValue("@MedicationName", m.MedicationName);
                    cmd.Parameters.AddWithValue("@PrescribedFor", m.PrescribedFor);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Medication Updated succesfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteMedication(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("deleteM", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MedicationId", id);

                    DialogResult dg = MessageBox.Show("Are you sure you want to delete Med "+id,"Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dg != DialogResult.Yes)
                    {
                        MessageBox.Show("Confrimed not to delete", "Confrirmed");
                        return;
                    }


                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Medication Deleted succesfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet getMedication()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getM", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Medications");
                return ds;
            }
        }



        //..
        //.. STAFF MANIPULATION
        public void saveStaff(Staff s)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StaffId", s.StaffId);
                    cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", s.LastName);
                    cmd.Parameters.AddWithValue("@Role", s.Role);
                    cmd.Parameters.AddWithValue("@Username", s.Username);
                    cmd.Parameters.AddWithValue("@Password", s.Password);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Staff Saved succesfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updateStaff(Staff s)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("updateS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StaffId", s.StaffId);
                    cmd.Parameters.AddWithValue("@FirstName", s.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", s.LastName);
                    cmd.Parameters.AddWithValue("@Role", s.Role);
                    cmd.Parameters.AddWithValue("@Username", s.Username);
                    cmd.Parameters.AddWithValue("@Password", s.Password);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Staff Updated succesfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void deleteStaff(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("deleteS", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@StaffId", id);


                    DialogResult dg = MessageBox.Show("Are you sure you want to delete Staff member " + id, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg != DialogResult.Yes)
                    {
                        MessageBox.Show("Confrimed not to delete", "Confrirmed");
                        return;
                    }

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Staff Deleted succesfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet getStaff()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getS", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Staff");
                return ds;
            }
        }
        public DataSet getAdmins()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getAdmins", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Admins");
                return ds;
            }
        }
        public DataSet getSurgeons()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getSurgeons", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Surgeons");
                return ds;
            }
        }
        public DataSet getNurses()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getNurses", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Nurses");
                return ds;
            }
        }



        //..
        //.. PRESCRIPTION MANIPULATION
        public void savePrescription(Prescriptions p)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insertPre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PrescriptionId", p.PrescriptionId);
                    cmd.Parameters.AddWithValue("@PatientId", p.PatientId);
                    cmd.Parameters.AddWithValue("@MedicationId", p.MedicationId);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Prescription Saved succesfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void updatePrescription(Prescriptions p)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("updatePre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PrescriptionId", p.PrescriptionId);
                    cmd.Parameters.AddWithValue("@PatientId", p.PatientId);
                    cmd.Parameters.AddWithValue("@MedicationId", p.MedicationId);

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Prescription Updated succesfully.", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void deletePrescription(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("deletePre", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PrescriptionId", id);


                    DialogResult dg = MessageBox.Show("Are you sure you want to delete prescription " + id, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg != DialogResult.Yes)
                    {
                        MessageBox.Show("Confrimed not to delete", "Confrirmed");
                        return;
                    }

                    int changes = cmd.ExecuteNonQuery();
                    if (changes > 0)
                    {
                        MessageBox.Show("Prescription Deleted succesfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataSet getPrescription()
        {
            using (con = new SqlConnection(str))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("getPre", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                da.Fill(ds, "Prescription");
                return ds;
            }
        }

        public string getPatientName(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("getPatientFirstName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientId", id);
                    string firstname = (String)cmd.ExecuteScalar();


                    cmd = new SqlCommand("getPatientLastName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientId", id);
                    string lastname = (String)cmd.ExecuteScalar();

                    return firstname + " " + lastname;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        public string getMedicationName(int id)
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("getMedicationName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("MedicationId", id);
                    string medication = (String)cmd.ExecuteScalar();

                    return medication;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }



        //..
        //.. OTHER MANIPULATIONS
        public void logout()
        {
            try
            {
                using (con = new SqlConnection(str))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("logout", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
