using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarbabBuissness
{
    class PatientBll
    {
        string Patient_Name
        {

            get
            {
                return this.Patient_Name;
            }
            set
            {
                this.Patient_Name = value;
            }

        }
        string Patient_Address
        {
            get
            {
                return this.Patient_Address;


            }

            set

            {
                this.Patient_Address = value;

            }
        }
        string Patient_Gender
        {

            get
            {
                return this.Patient_Gender;
            }
            set
            {
                this.Patient_Gender = value;
            }

        }

        int Patient_Dob
        {

            get
            {
                return this.Patient_Dob;
            }
            set
            {
                this.Patient_Dob = value;
            }

        }
        int Patient_Contact
        {

            get
            {
                return this.Patient_Contact;
            }
            set
            {
                this.Patient_Contact = value;
            }

        }
        int Doctor_ID
        {

            get
            {
                return this.Doctor_ID;
            }
            set
            {
                this.Doctor_ID = value;
            }

        }

        int Checkup_Date
        {

            get
            {
                return this.Checkup_Date;
            }
            set
            {
                this.Checkup_Date = value;
            }

        }
        int Product_ID
        {

            get
            {
                return this.Product_ID;
            }
            set
            {
                this.Product_ID = value;
            }

        }
        int Product_Quality
        {

            get
            {
                return this.Product_Quality;
            }
            set
            {
                this.Product_Quality = value;
            }

        }
        int Bill_ID
        {

            get
            {
                return this.Bill_ID;
            }
            set
            {
                this.Bill_ID = value;
            }




        }
          MessageBox.Show("saved");



    }
}
