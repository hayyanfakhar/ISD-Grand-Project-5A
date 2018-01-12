using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class prescribedmed_bll
    {
       PRESCRIBE_MEDICINE pre = new PRESCRIBE_MEDICINE();
        dll dll = new dll();

        int id
        {

            get
            {

                return this.id;
            }
            set
            {

                this.id = value;
            }
        }
        int v_id
        {

            get
            {

                return this.v_id;
            }
            set
            {

                this.v_id = value;
            }
        }
        int m_id
        {

            get
            {

                return this.m_id;
            }
            set
            {

                this.m_id = value;
            }
        }
        public void prescribedmed_valid()
        {
            if (pre.txtid.Text == string.Empty)
            {
                MessageBox.Show("no textbox should be empty");
            }
            else if (pre.cbvisitid.Text == string.Empty)
            {
                MessageBox.Show("no textbox should be empty");

            }
            else if (pre.cbmedid.Text == string.Empty)
            {
                MessageBox.Show("no textbox should be empty");
            }
        }
    }

  
}
