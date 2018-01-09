using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllClinic
{
    class DLL
    {
        int count = 0;

        public static SqlConnection con;

        public static SqlConnection getConnection()
        {

            con = new SqlConnection("Data Source=(local);Initial Catalog=ClinicSystem;Integrated Security=True");
            con.Open();
            return con;

            

        }
          //  public bool insertPatient(string Patient_Name, string Patient_Address, bool Patient_Gender, int Patient_Dob, int Patient_Contact)
        {
            try
            {
                getConnection();
                string query = "exec AddPatient";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        //public int genPatient_ID()
        //{
        //    getConnection();
        //    string query = "Select max(PatientID) from Patients";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.ExecuteNonQuery();
        //    count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
        //    con.Close();

        //    return count;
        //}



        //public bool insertDoctor(String Doctor_Name, String Doctor_Qualification, String Doctor_Designation, String Status_Type, int Doctor_Fee)
        //{
        //    try {
        //        getConnection();
        //        string query = "insert into Doctors(Doctor_Name, Doctor_Qualification, Doctor_Designation, Status_Type, Doctor_Fee)values('" + Doctor_Name + "' , '" + Doctor_Qualification + "','" + Doctor_Designation + "','" + Status_Type + "','" + Doctor_Fee "' )";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return true;
        //    }


       //public int genDoctor_ID()
       // {

       //     getConnection();
       //     string query = "Select max(Doctor_ID) from Doctors";
       //     SqlCommand cmd = new SqlCommand(query, con);
       //     count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
       //     con.Close();

       //     return count;


       // }

        //    public bool insertBill(int Bill_ID,int Visit_ID, int Doctor_Fee)
        //{
        //    try
        //    {
        //        getConnection();
        //        string query = "Exec "


        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return true;
        //}


        public bool InsertMedicine(String Med_Name, int Cost)
        {
            try
            {
                getConnection();
                String query = "Exec AddMedicine";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;
        }


        public bool UpdatePatient(int Patient_ID, string Patient_Name, string Patient_Address, string Patient_Gender, int Patient_Dob, int Patient_Contact)
        {
            try
            {
                getConnection();
                String query = "Exec UpdatePatient";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public bool UpdateDoctor(int Doctor_ID, String Doctor_Name, String Doctor_Qualification, String Doctor_Designation, String Status_Type, int Doctor_Fee)
        {
            
                try
                {
                    getConnection();
                    String query = "Exec UpdateDoctor ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    ex.Message.ToString();
                }
                finally
                {
                    con.Close();
                }
                return true;
            

        }

        //public bool UpdateBill(int Bill_ID, int Visit_ID, int Doctor_Fee)
        //{
        //    try
        //    {
        //        getConnection();
        //        String query = "UPDATE Bill SET Bill_ID='" + Bill_ID + "', Visit_ID='" + Visit_ID + "', Doctor_Fee='" + Doctor_Fee + "' WHERE Bill_ID =" + Bill_ID + " ";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return true;
        //}

        public bool UpdateMedicine(int Med_ID, String Med_Name, int Cost)
        {
            try
            {
                getConnection();
                String query = "Exec UpdateMedicine";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;


        }

        //public bool Pharmacy(int Phar_ID, int Pharmacy_Bill, int Visit_ID)
        //{
        //    try
        //    {
        //        getConnection();
        //        String query = "insert into Pharmacy(Phar_ID, Pharmacy_Bill, Visit_ID)values('" + Phar_ID + "','" + Pharmacy_Bill + "','" + Visit_ID + "' )";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return true;
        //}

        //public bool UpdatePharmacy(int Phar_ID, int Pharmacy_Bill, int Visit_ID)
        //{
        //    try
        //    {
        //        getConnection();
        //        String query = "UPDATE Pharmacy SET Phar_ID='" + Phar_ID + "', Pharmacy_Bill='" + Pharmacy_Bill + "', Visit_ID='" + Visit_ID + "' WHERE Phar_ID =" + Phar   _ID + " ";
        //        SqlCommand cmd = new SqlCommand(query, con);
        //        cmd.ExecuteNonQuery();


        //    }
        //    catch (Exception ex)
        //    {
        //        ex.Message.ToString();
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return true;


        //}

        public bool DeleteMedicine(int Med_ID, String Med_Name, int Cost)
        {
            try
            {
                getConnection();
                String query = "Exec DeleteMedicine";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;


        }

        public bool DeletePatient(int Patient_ID)
        {
            try
            {
                getConnection();
                string query = "exec DeletePatient";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;
        }

        public bool PatientData(DataGridView dgv)
        {
            try
            {
                GetConnection();
                DataTable dt = new DataTable();
                string query = "EXEC getAllPatients ";
                SqlDataAdapter sa = new SqlDataAdapter(query, con);
                sa.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;

        }

        public bool SinglePatientData(DataGridView dgv)
        {
            try
            {
                GetConnection();
                DataTable dt = new DataTable();
                string query = "EXEC getPatientByName ";
                SqlDataAdapter sa = new SqlDataAdapter(query, con);
                sa.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;

        }

        public bool DoctorData(DataGridView dgv)
        {
            try
            {
                GetConnection();
                DataTable dt = new DataTable();
                string query = "EXEC getAllDoctor";
                SqlDataAdapter sa = new SqlDataAdapter(query, con);
                sa.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;

        }



        public bool MedicineData(DataGridView dgv)
        {
            try
            {
                GetConnection();
                DataTable dt = new DataTable();
                string query = "EXEC getMedicineList";
                SqlDataAdapter sa = new SqlDataAdapter(query, con);
                sa.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                ex.Message.ToString();
            }
            finally
            {
                con.Close();
            }
            return true;

        }



        public string showDoctor(ComboBox comLevels)
        {
            GetConnection();
            string query = "EXEC getDoctor ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comLevels.Items.Add(reader["Doctor_ID"]);
            }
            comLevels.SelectedIndex = 0;
            con.Close();
            return query;
        }


        public string showMedicine(ComboBox comLevels)
        {
            GetConnection();
            string query = "EXEC getMedicine";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comLevels.Items.Add(reader["Med_ID"]);
            }
            comLevels.SelectedIndex = 0;
            con.Close();
            return query;
        }

        public string showPharmacyBill(ComboBox comLevels)
        {
            GetConnection();
            string query = "EXEC getPharmacyBill";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comLevels.Items.Add(reader["Phar_ID"]);
            }
            comLevels.SelectedIndex = 0;
            con.Close();
            return query;
        }

        public string showPatient(ComboBox comLevels)
        {
            GetConnection();
            string query = "EXEC getPatients";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comLevels.Items.Add(reader["Patient_ID"]);
            }
            comLevels.SelectedIndex = 0;
            con.Close();
            return query;
        }

        public string showPatientBill(ComboBox comLevels)
        {
            GetConnection();
            string query = "EXEC getPatientBill";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comLevels.Items.Add(reader["Bill_ID"]);
            }
            comLevels.SelectedIndex = 0;
            con.Close();
            return query;
        }

    }

}

    

