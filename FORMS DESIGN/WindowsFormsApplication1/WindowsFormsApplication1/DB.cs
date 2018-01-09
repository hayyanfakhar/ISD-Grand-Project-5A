using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class DB
    {
        int count = 0;

        public static SqlConnection con;

        public static SqlConnection getConnection()
        {

            con = new SqlConnection("Data Source=(local);Initial Catalog=ClinicSystem;Integrated Security=True");
            con.Open();
            return con;



        }
        public bool insertPatient(string Patient_Name, string Patient_Address, bool Patient_Gender, int Patient_Dob, int Patient_Contact)
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

        public int genPatient_ID()
        {
            getConnection();
            string query = "Exec getPatientID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            con.Close();

            return count;
        }
        public bool UpdatePatient(int Patient_ID, string Patient_Name, string Patient_Address, bool Patient_Gender, int Patient_Dob, int Patient_Contact)
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

        public bool InsertVisit(DateTime Visit_Date, int Patient_ID, int Doctor_ID)
        {
            try
            {
                getConnection();
                String query = "Exec AddVisit";
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
        public bool UpdateVisit(int Visit_ID, DateTime Visit_Date, int Patient_ID, int Doctor_ID)
        {
            try
            {
                getConnection();
                String query = "Exec UpdateVisit";
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
        public int genVisitID()
        {
            getConnection();
            string query = "Exec getVisit";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            count = Convert.ToInt16(cmd.ExecuteScalar()) + 1;
            con.Close();

            return count;
        }

        public bool PatientData(DataGridView dgv)
        {
            try
            {
                getConnection();
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
        public string showPatientData(TextBox txtpatid, TextBox txtpatname, TextBox txtpatadd, RadioButton rbmale, RadioButton rbfemale, DateTimePicker dateTimePicker1, TextBox txtpatnumber)
        {
            getConnection();
            string query = "SELECT * from author where Patient_ID ='" + txtpatid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtpatname.Text = reader["txtpatname"].ToString();
                txtpatadd.Text = reader["txtpatadd"].ToString();
                rbmale.Text = reader["rbmale"].ToString();
                dateTimePicker1.Text = reader["dateTimePicker1"].ToString();
                txtpatnumber.Text = reader["txtpatnumber"].ToString();


            }
            con.Close();
            return query;
        }


        public string showVisitData(TextBox txtappid, TextBox txtappdate, ComboBox cbpatid, ComboBox cbdocid)
        {
            getConnection();
            string query = "SELECT * from publisher where Visit_ID ='" + txtappid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                txtappdate.Text = reader["txtappdate"].ToString();
                cbpatid.Text = reader["cbpatid"].ToString();
                cbdocid.Text = reader["cbdocid"].ToString();

            }
            con.Close();
            return query;
        }
        public bool BillData(DataGridView dgv)
        {
            try
            {
                getConnection();
                DataTable dt = new DataTable();
                string query = "EXEC getBill ";
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

        public bool VisitData(DataGridView dgv)
        {
            try
            {
                getConnection();
                DataTable dt = new DataTable();
                string query = "EXEC getVisit ";
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

    }
}
