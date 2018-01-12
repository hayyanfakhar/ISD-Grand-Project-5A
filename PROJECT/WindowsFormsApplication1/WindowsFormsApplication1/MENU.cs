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
    public partial class MENU : MetroFramework.Forms.MetroForm
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnpat_Click(object sender, EventArgs e)
        {
            PATIENT obj = new PATIENT();
            obj.Show();
        }

        private void btnapp_Click(object sender, EventArgs e)
        {
            APPOINTMENT obj = new APPOINTMENT();
            obj.Show();
        }

        private void btnvpat_Click(object sender, EventArgs e)
        {
            VIEWPATIENT obj = new VIEWPATIENT();
            obj.Show();
        }

        private void btnvapp_Click(object sender, EventArgs e)
        {
            VIEWAPPOINTMENT obj = new VIEWAPPOINTMENT();
            obj.Show();
        }

        private void btnpmed_Click(object sender, EventArgs e)
        {
            PRESCRIBE_MEDICINE obj = new PRESCRIBE_MEDICINE();
            obj.Show();
        }

        private void btnmed_Click(object sender, EventArgs e)
        {
            MEDICINE obj = new MEDICINE();
            obj.Show();
        }

        private void btnvmed_Click(object sender, EventArgs e)
        {
            MEDICINELIST obj = new MEDICINELIST();
            obj.Show();
        }
        public void repload()
        {
            panel1.Enabled = true;
            panel2.Enabled = false;
            panel3.Enabled = false;
        }
        public void docload()
        {
            panel1.Enabled = false;
            panel2.Enabled = true;
            panel3.Enabled = false;
        }
        public void phload()
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = true;
        }
        private void MENU_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            login.Show();
            this.Close();
        }
    }
}
