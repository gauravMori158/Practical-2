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
            customer_accountNo = acNumber;
            customer_name = cName;

        }

        /// <summary>
        /// PrintInfo() method returns well formatted string that contains User information
        /// </summary>
        /// <returns>String</returns>
        public string PrintInfo()
        { 
            return $"Output\nBank Name : {bank_name}\n" +
                   $"Customer Name : {customer_name}\n" +
                   $"Account Number : {customer_accountNo}";
        }

        public static void Main(string[] args)
        {
            Customer_Account customer_Account = new Customer_Account(121212121221, "Gaurav Mori");
            customer_Account.bank_name = "HDFC India";
            Console.WriteLine(customer_Account.PrintInfo());
        }
    }
}
