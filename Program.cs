using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter account id:");
            int acc_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account name:");
            string acc_name = Console.ReadLine();
            Console.WriteLine("enter account bal:");
            int acc_bal = Convert.ToInt32(Console.ReadLine());
            account obj = new account(acc_id, acc_name, acc_bal);

            Console.WriteLine("enter amount to deposit:");
            int amt = Convert.ToInt32(Console.ReadLine());
            obj.deposit(amt);
            int bal = obj.getbalance();
            Console.WriteLine("balance :" + bal);

            Console.WriteLine("enter amount to withdraw");
            amt = Convert.ToInt32(Console.ReadLine());
            obj.withdraw(amt);
            bal = obj.getbalance();
            Console.WriteLine("remainng balance" + bal);
            Console.ReadLine();

            /*Console.WriteLine("enter emp id:");
            int empid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter emp name:");
            string empname = Console.ReadLine();

            Console.WriteLine("enter emp salary:");
            int empsal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter emp city:");
            string empcity = Console.ReadLine();

            employee obj = new employee(empid, empname, empsal, empcity);
            string details = obj.Getdetails();
            Console.WriteLine(details);
            Console.WriteLine("enter no. of days");
            int days = Convert.ToInt32(Console.ReadLine());
            double salary = obj.Getsal(days);
            Console.WriteLine("salary:" + salary);
            Console.ReadLine();*/

            /*Console.WriteLine("enter customer id:");
            int customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer name:");
            string customername = Console.ReadLine();
            Console.WriteLine("enter customer email:");
            string customermail = Console.ReadLine();
            customer obj = new customer(customerid, customername, customermail);
            string str = obj.Getdetails();
            Console.WriteLine(str);
            Console.ReadLine();*/
            //Console.WriteLine("enter order id:");
            //int orderid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter customer name:");
            //string customername = Console.ReadLine();
            //Console.WriteLine("enter item name:");
            //string itemname = Console.ReadLine();
            //Console.WriteLine("enter item price:");
            //int itemprice = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter item qty:");
            //int itemqty = Convert.ToInt32(Console.ReadLine());
            //order obj = new order(orderid, customername, itemname,itemprice,itemqty);
            //int a=obj.orderamt();
            //Console.WriteLine("order amt:" + a);
            //Console.ReadLine();

            /*Console.WriteLine("enter account id:");
            int acc_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account name:");
            string acc_name = Console.ReadLine();
            Console.WriteLine("enter account bal:");
            int acc_bal = Convert.ToInt32(Console.ReadLine());
            account obj = new account(acc_id, acc_name, acc_bal);

            Console.WriteLine("enter amount to deposit:");
            int amt = Convert.ToInt32(Console.ReadLine());
            obj.deposit(amt);
            int bal = obj.getbalance();
            Console.WriteLine("balance :" +bal );

            Console.WriteLine("enter amount to withdraw");
            amt = Convert.ToInt32(Console.ReadLine());
            obj.withdraw(amt);
            bal = obj.getbalance();
            Console.WriteLine("remainng balance" + bal);
            Console.ReadLine();*/

        }
    }


            /*Console.WriteLine("enter emp id:");
            int emp_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter emp name:");
            string emp_name = Console.ReadLine();

            Console.WriteLine("enter emp salary:");
            double emp_sal=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter emp city:");
            string emp_city = Console.ReadLine();

            employee obj = new employee(emp_id,emp_name,emp_sal,emp_city);
            string details = obj.Getdetails();
            Console.WriteLine(details);
            Console.WriteLine("enter no. of days");
            int days = Convert.ToInt32(Console.ReadLine());
            double salary = obj.Getsal(days);
            Console.WriteLine("salary:" + salary);*/

            /* Console.WriteLine("enter customer id:");
             int customer_id = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter customer name:");
             string customer_name = Console.ReadLine();
             Console.WriteLine("enter customer email:");
             string customer_mail = Console.ReadLine();
             customer obj = new customer(customer_id,customer_name,customer_mail);
             string str = obj.Getdetails();
             Console.WriteLine(str);*/
            
        }
    

