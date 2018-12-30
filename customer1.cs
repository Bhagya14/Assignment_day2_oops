using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleoop2
{
    class customer1
    {
        private int customerid;
        private string customername;
        private string customermail;
        public customer1(int customer_id, string customer_name, string customer_mail)
        {
            this.customerid = customer_id;
            this.customername = customer_name;
            this.customermail = customer_mail;
        }
        public string Getdetails()
        {
            return this.customerid + " " + this.customername + " " + this.customermail;
        }
    }
}
