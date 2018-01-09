using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsadZarbabBll
{
    class login
    {

        string Password
        {


            get
            {

                return this.Password;

            }

            set
            {
                this.Password = "123";


            }
        }
        string username
        {

            get
            {

                return this.username;

            }

            set
            {
                this.username = "rec";


            }
        }
        string Password2
        {


            get
            {

                return this.Password2;

            }

            set
            {
                this.Password2 = "123";


            }
        }
        string username2
        {

            get
            {

                return this.username2;

            }

            set
            {
                this.username2 = "doc";


            }
        }
        string Password3
        {


            get
            {

                return this.Password3;

            }

            set
            {
                this.Password3 = "123";


            }
        }
        string username3
        {

            get
            {

                return this.username3;

            }

            set
            {
                this.username3 = "pharm";


            }



        } 

        if ((this.TextBox.Text == "Admin") && (this.textBox2.Text == "123"))  
            { //open admin form }
            else if ((this.textBox1.Text == "doc") && (this.textBox2.Text == "123"))  
            { //open doctor form  }
            else  if ((this.textBox1.Text == "pharm") && (this.textBox2.Text == "123"))  
            {  //open pharmacist form }
            else{ MessageBox.Show("wrong username/password, enter again.!");
              }
}
} 
