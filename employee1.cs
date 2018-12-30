using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleoop2
{
    class employee1
    {
        private int empid;
        private string empname;
        private int empsal;
        private string empcity;
        public employee1(int emp_id, string emp_name, int emp_sal, string emp_city)
        {
            this.empid = emp_id;
            this.empname = emp_name;
            this.empsal = emp_sal;
            this.empcity = emp_city;
        }
        public string Getdetails()
        {
            return this.empid + " " + this.empname + " " + this.empcity;
        }
        public double Getsal(int days)
        {
            return (this.empsal / 30) * days;
        }
    }
}
