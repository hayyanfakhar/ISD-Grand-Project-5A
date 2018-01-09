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
        public APPOINTMENT()
        {
            InitializeComponent();
        }
        
        private void btncancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void APPOINTMENT_Load(object sender, EventArgs e)
        {
            txtappdate.Text = System.DateTime.Now.Date.ToString();
        }
    }
}
