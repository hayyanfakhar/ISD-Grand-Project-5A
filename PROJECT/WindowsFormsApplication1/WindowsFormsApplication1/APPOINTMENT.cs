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
    public partial class APPOINTMENT : MetroFramework.Forms.MetroForm
    {
        DB dbobj = new DB();
        public APPOINTMENT()
        {
            InitializeComponent();
        }
        private void Refresh2()
        {
            //txtappid.Text = dbobj.genVisitID().ToString();
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void APPOINTMENT_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            txtappid.Visible = false;
            txtappdate.Visible = false;
            cbpatid.Visible = false;
            cbdocid.Visible = false;
            btncancel.Visible = false;
            btnsave.Visible = false;
            btnupdate.Visible = false;
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbobj.InsertVisit(Convert.ToDateTime(txtappdate.Text), Convert.ToInt32(cbpatid.Text), Convert.ToInt32(cbdocid.Text)))
                {
                    MessageBox.Show("data stored");
                    Refresh2();
                    txtappdate.Text = System.DateTime.Now.Date.ToString();
                    cbpatid.Text = "";
                    cbdocid.Text = "";
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
                if (dbobj.UpdateVisit(int.Parse(txtappid.Text) ,Convert.ToDateTime(txtappdate.Text), Convert.ToInt32(cbpatid.Text), Convert.ToInt32(cbdocid.Text)))
                {
                    MessageBox.Show("data stored");
                    txtappdate.Text = "";
                    cbpatid.Text = "";
                    cbdocid.Text = "";
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

        private void rbadd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadd.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtappid.Visible = true;
                txtappdate.Visible = true;
                cbpatid.Visible = true;
                cbdocid.Visible = true;
                btncancel.Visible = true;
                btnsave.Visible = true;
                btnupdate.Visible = false;
                txtappid.Enabled = false;
                Refresh2();
                txtappdate.Text = System.DateTime.Now.Date.ToString();
                txtappid.Text = "";
                cbdocid.Text = "";
                cbpatid.Text = "";
            }
        }

        private void rbupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadd.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                txtappid.Visible = true;
                txtappdate.Visible = true;
                cbpatid.Visible = true;
                cbdocid.Visible = true;
                btncancel.Visible = true;
                btnsave.Visible = false;
                btnupdate.Visible = true;
                txtappid.Enabled = true;
                txtappid.Text = null;
            }
        }
    }
}
