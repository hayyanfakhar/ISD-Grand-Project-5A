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
    public partial class PATIENT : MetroFramework.Forms.MetroForm
    {
        DB dbobj = new DB();
        public PATIENT()
        {
            InitializeComponent();
        }

        private void PATIENT_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txtpatid.Visible = false;
            txtpatname.Visible = false;
            txtpatadd.Visible = false;
            comboBox1.Visible = false;
            dateTimePicker1.Visible = false;
            txtpatnumber.Visible = false;
            btncancel.Visible = false;
            btnsave.Visible = false;
            btnupdate.Visible = false;
        }

        private void rbadd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbadd.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                txtpatid.Visible = true;
                txtpatname.Visible = true;
                txtpatadd.Visible = true;
                comboBox1.Visible = true;
                dateTimePicker1.Visible = true;
                txtpatnumber.Visible = true;
                btncancel.Visible = true;
                btnsave.Visible = true;
                btnupdate.Visible = false;
                txtpatid.Enabled = false;
                Refresh2();
                txtpatid.Text = "";
                txtpatname.Text = "";
                txtpatadd.Text = "";
                txtpatnumber.Text = "";
            }
        }

        private void rbupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbupdate.Checked == true)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                txtpatid.Visible = true;
                txtpatname.Visible = true;
                txtpatadd.Visible = true;
                comboBox1.Visible = true;
                dateTimePicker1.Visible = true;
                txtpatnumber.Visible = true;
                btncancel.Visible = true;
                btnsave.Visible = false;
                btnupdate.Visible = true;
                txtpatid.Enabled = true;
                txtpatid.Text = null;
            }

          }
        private void Refresh2()
        {
         //   txtpatid.Text = dbobj.genPatient_ID().ToString();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
                try
                {
                    if (dbobj.insertPatient(txtpatname.Text, txtpatadd.Text, Convert.ToBoolean(comboBox1.Text) , Convert.ToInt32(dateTimePicker1), Convert.ToInt32(txtpatnumber.Text)))
                    {
                        MessageBox.Show("data stored");
                        Refresh2();
                        txtpatname.Text = "";
                        txtpatadd.Text = "";
                        txtpatnumber.Text = "";
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
                if (dbobj.UpdatePatient(int.Parse(txtpatid.Text) ,txtpatname.Text, txtpatadd.Text, Convert.ToBoolean(comboBox1.Text), Convert.ToInt32(dateTimePicker1), Convert.ToInt32(txtpatnumber.Text)))
                {
                    MessageBox.Show("data updated");
                    txtpatid.Text = "";
                    txtpatname.Text = "";
                    txtpatadd.Text = "";
                    txtpatnumber.Text = "";
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
