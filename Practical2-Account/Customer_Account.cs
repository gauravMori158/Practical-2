using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_Account
{
    class Customer_Account
    {
        public string bank_name;
        private long customer_accountNo;
        private string customer_name;

        public Customer_Account(long acNumber, string cName)
        {
            this.customer_accountNo = acNumber;
            this.customer_name = cName;

        }

        /* 
         -  PrintInfo() method is used for displaying User information.
            i.e it displays Account Number (long int ) , Customer Name(string ) and Bank Name (sting) .
            it takes 0 argument and returns 0.
         */
        public void PrintInfo()
        {
            System.Console.WriteLine("Output");
            Console.WriteLine("Bank Name : " + bank_name);
            Console.WriteLine("Customer Name : " + customer_name);
            Console.WriteLine("Account Number : " + customer_accountNo);
        }

        public static void Main(string[] args)
        {
            Customer_Account customer_Account = new Customer_Account(121212121221,"Gaurav Mori");
            customer_Account.bank_name = "HDFC India";
            customer_Account.PrintInfo();
        }
    }
}
