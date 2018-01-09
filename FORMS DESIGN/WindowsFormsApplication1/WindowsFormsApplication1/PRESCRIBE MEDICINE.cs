using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PRESCRIBE_MEDICINE : MetroFramework.Forms.MetroForm
    {
        DB dbobj = new DB();
        public PRESCRIBE_MEDICINE()
        {
            InitializeComponent();
        }

        private void PRESCRIBE_MEDICINE_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicSystemDataSet2.Medicine' table. You can move, or remove it, as needed.
            this.medicineTableAdapter.Fill(this.clinicSystemDataSet2.Medicine);
            // TODO: This line of code loads data into the 'clinicSystemDataSet1.Visit' table. You can move, or remove it, as needed.
            this.visitTableAdapter.Fill(this.clinicSystemDataSet1.Visit);
            // TODO: This line of code loads data into the 'clinicSystemDataSet.Visit_Medicine' table. You can move, or remove it, as needed.
            this.visit_MedicineTableAdapter.Fill(this.clinicSystemDataSet.Visit_Medicine);
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtid.Visible = false;
            cbmedid.Visible = false;
            cbvisitid.Visible = false;
            btncancel.Visible = false;
            btnsave.Visible = false;
            btnupdate.Visible = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbadd.Checked == true)//(dbobj.insertVisitMed(Convert.ToInt32(cbvisitid.Text), Convert.ToInt32(cbmedid.Text)))
                {
                    MessageBox.Show("data stored");
                    Refresh2();
                    cbvisitid.Text = "";
                    cbmedid.Text = "";
                }
                else
                {
                    MessageBox.Show("unhandled exception");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

   

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if(rbadd.Checked == true)//(dbobj.updateVisitMed(Convert.ToInt32(txtid.text) ,Convert.ToInt32(cbvisitid.Text), Convert.ToInt32(cbmedid.Text)))
                {
                    MessageBox.Show("data updated");
                    cbvisitid.Text = "";
                    cbmedid.Text = "";
                }
                else
                {
                    MessageBox.Show("unhandled exception");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void rbadd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadd.Checked == true)
            {
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtid.Visible = true;
                cbmedid.Visible = true;
                cbvisitid.Visible = true;
                btncancel.Visible = true;
                btnsave.Visible = true;
                btnupdate.Visible = false;
                txtid.Enabled = false;
                Refresh2();
                txtid.Text = "";
                cbmedid.Text = "";
                cbvisitid.Text = "";
            }
        }

        private void rbupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbupdate.Checked == true)
            {
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtid.Visible = true;
                cbmedid.Visible = true;
                cbvisitid.Visible = true;
                btncancel.Visible = true;
                btnsave.Visible = false;
                btnupdate.Visible = true;
                txtid.Enabled = true;
                txtid.Text = null;

            }
        }

        private void Refresh2()
        {
               //txtid.Text = dbobj.genPatient_ID().ToString();
        }
    }
}
