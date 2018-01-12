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
    public partial class LOGIN : MetroFramework.Forms.MetroForm
    {
        DB dbobj = new DB();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            dbobj.Login(txtusername.Text, txtpassword.Text, comboBox1.Text);
            if (comboBox1.Text == "RECEPTIONIST")
            {
                MENU OBJ = new MENU();
                OBJ.Show();
                OBJ.repload();       
                     
            }
            if (comboBox1.Text == "DOCTOR")
            {
                MENU OBJ = new MENU();
                OBJ.Show();
                OBJ.docload();
            }
            if (comboBox1.Text == "PHARMACIST")
            {
                MENU OBJ = new MENU();
                OBJ.Show();
                OBJ.phload();
            }
            this.Hide();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicSystemDataLOGIN.Logins' table. You can move, or remove it, as needed.
            this.loginsTableAdapter.Fill(this.clinicSystemDataLOGIN.Logins);

        }
    }
}
