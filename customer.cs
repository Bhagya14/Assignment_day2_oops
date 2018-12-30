using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleoop2
{
    class customer
    {
        private int customer_id;
        private string customer_name;
        private string customer_mail;
        public customer()
        {
            Console.WriteLine("default constructor");
        }
        public customer(int customer_id,string customer_name,string customer_mail)
        {
            this.customer_id = customer_id;
            this.customer_name = customer_name;
            this.customer_mail = customer_mail;
            Console.WriteLine("paramerized constructor");
        }
        public string Getdetails()
        {
            return this.customer_id + " " + this.customer_name + " " + this.customer_mail;
        }
    }
}
