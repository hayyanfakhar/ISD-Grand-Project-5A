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
    public partial class MEDICINELIST : MetroFramework.Forms.MetroForm
    {
        DB dbobj = new DB();
        public MEDICINELIST()
        {
            InitializeComponent();
        }

        private void MEDICINELIST_Load(object sender, EventArgs e)
        {
            dbobj.MedicineData(dataGridView1);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
