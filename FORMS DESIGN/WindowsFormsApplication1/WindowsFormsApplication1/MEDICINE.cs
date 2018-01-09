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
    public partial class MEDICINE : MetroFramework.Forms.MetroForm
    {
        DB dbobj = new DB();
        public MEDICINE()
        {
            InitializeComponent();
        }

        private void MEDICINE_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtmedid.Visible = false;
            txtmedname.Visible = false;
            txtmedcost.Visible = false;
            btncancel.Visible = false;
            btnsave.Visible = false;
            btnupdate.Visible = false;
        }

        private void rbadd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadd.Checked == true)
            {
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            txtmedid.Visible = true;
            txtmedname.Visible = true;
            txtmedcost.Visible = true;
            btncancel.Visible = true;
            btnsave.Visible = true;
            btnupdate.Visible = false;
            txtmedid.Enabled = false;
            Refresh2();
            txtmedname.Text = "";
            txtmedcost.Text = "";
            }
        }

        private void rbupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbupdate.Checked == true)
            {
                label1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtmedid.Visible = true;
                txtmedname.Visible = true;
                txtmedcost.Visible = true;
                btncancel.Visible = true;
                btnsave.Visible = false;
                btnupdate.Visible = true;
                txtmedid.Enabled = true;
                txtmedid.Text = null;
            }
        }
        private void Refresh2()
        {
            //   txtmedid.Text = dbobj.genPatient_ID().ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbobj.InsertMedicine(txtmedname.Text, int.Parse(txtmedcost.Text)))
                {
                    MessageBox.Show("data stored");
                    Refresh2();
                    txtmedname.Text = "";
                    txtmedcost.Text = "";
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
                if (dbobj.UpdateMedicine(int.Parse(txtmedid.Text) ,txtmedname.Text, int.Parse(txtmedcost.Text)))
                {
                    MessageBox.Show("data updated");
                    txtmedid.Text = "";
                    txtmedname.Text = "";
                    txtmedcost.Text = "";
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
    }
}
