using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Methods1
{
    class Account
    {

        long account_No;
        string Customer_name;

        public long acc_no
        {
            set { account_No = value; }
            get { return account_No; }
        }
        public string name
        {
            set { Customer_name = value; }
            get { return Customer_name; }

        }


        static void Main(string[] args)
        {
            Account a = new Account();
            a.acc_no = 3622548753;
            a.name = "Shivam Thorat";

            Console.WriteLine("Account Number is "+a.acc_no);
            Console.WriteLine("Account Name is "+a.name);

            Account a1 = new Account();
            a1.acc_no = 6574552897;
            a1.name = "ChanduLal";
            Console.WriteLine("\nAccount Number is " + a1.acc_no);
            Console.WriteLine("Account Name is " + a1.name);

        }
    }
}
