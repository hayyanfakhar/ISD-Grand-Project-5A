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
    public partial class SEARCH : MetroFramework.Forms.MetroForm
    {
        DB dbobj = new DB();
        public SEARCH()
        {
            InitializeComponent();
        }

        private void SEARCH_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "APPOINTMENT")
            {
                dbobj.VisitData(dataGridView1);
            }
            if (comboBox1.Text == "PATIENT")
            {
                dbobj.PatientData(dataGridView1);
            }
            if (comboBox1.Text == "BILL")
            {
                dbobj.BillData(dataGridView1);
            }
        }
    }
}
