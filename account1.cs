using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleoop2
{
    class account1
    {
        private int acc_id;
        private string acc_name;
        public int acc_bal;
        public account1(int acc_id, string acc_name, int acc_bal)
        :this(acc_id,acc_name)
        {
            this.acc_bal = acc_bal;
            Console.WriteLine("constructor2");
        }
        public account1(int acc_id, string acc_name)
        {
            this.acc_id = acc_id;
            this.acc_name = acc_name;
            Console.WriteLine("constructor1");
        }
        public void deposit(int amt)
        {

            acc_bal = acc_bal + amt;

        }
        public void withdraw(int amt)
        {

            acc_bal = acc_bal - amt;
        }
        public int getbalance()
        {
            return acc_bal;
        }

    }
}
