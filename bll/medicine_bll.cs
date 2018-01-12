using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication4
{
    class medicine_bll
    {
        dll dll = new dll();
 
            string Medicine_Name
            {

                get
                {

                    return this.Medicine_Name;
                }
                set
                {

                    this.Medicine_Name = value;
                }



            }
            int Medicine_ID
            {

                get
                {

                    return this.Medicine_ID;
                }
                set
                {

                    this.Medicine_ID = value;
                }



            }
            int Cost
            {

                get
                {

                    return this.Cost;
                }
                set
                {

                    this.Cost = value;
                }



            }

        } public void medicine_valid()
    {
        dll.MedicineData();
        if (txtmedid.text == string.Empty)
        {
            MessageBox.Show("no textbox should be empty");
        }
        else if(txtmedname.text== string.Empty)
        {
            MessageBox.Show("no textbox should be empty");

        }else if(txtmedcost.text == string.Empt)
        {
            MessageBox.Show("no textbox should be empty");
        }
    }
    }


