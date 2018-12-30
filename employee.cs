using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleoop2
{
    class employee
    {
        private int emp_id;
        private string emp_name;
        private double emp_sal;
        private string emp_city;
        public employee(int emp_id,string emp_name,double emp_sal,string emp_city)
        {
            this.emp_id = emp_id;
            this.emp_name = emp_name;
            this.emp_sal = emp_sal;
            this.emp_city = emp_city;
        }
        public string Getdetails()
        {
            return this.emp_id + " " + this.emp_name + " " + this.emp_city;
        }
        public double Getsal(int days)
        {
            return (this.emp_sal / 30) * days;
        }
    }
}
