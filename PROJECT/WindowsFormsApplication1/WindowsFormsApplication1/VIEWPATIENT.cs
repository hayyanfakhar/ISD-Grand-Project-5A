﻿using System;
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
    public partial class VIEWPATIENT : MetroFramework.Forms.MetroForm
    {
        DB dbobj = new DB();
        public VIEWPATIENT()
        {
            InitializeComponent();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void VIEWPATIENT_Load(object sender, EventArgs e)
        {
            dbobj.PatientData(dataGridView1);
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dbobj.SinglePatientData(dataGridView1);
        }
    }
}
