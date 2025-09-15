using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Account
    {
        long number;
        string accHolder;
        string type;
        int balance;
        string password;

        public void create(long number, string accHolder, string type, int balance, string password)
        {
            this.number = number;
            this.accHolder = accHolder;
            this.type = type;
            this.balance = balance;
            this.password = password;
        }

        public void display()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Account Holder's Name : " + accHolder);
            Console.WriteLine("Account Number : " + number);
            Console.WriteLine("Balance : " + balance);
            Console.WriteLine("Account type : " + type);
            Console.WriteLine("------------------------------------");
        }

        public bool auth(long acc, string password)
        {
            if(acc == number && password == this.password) 
                return true;
            else 
                return false;
        }

        public void deposite(int amt)
        {
            this.balance += amt;
        }

        public void withdraw(int amt)
        {
            if (amt > this.balance)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Sorry You dont have sufficient Balance ");
                Console.WriteLine("------------------------------------------");
            }

            else
            {
                this.balance -= amt;

                Console.WriteLine("------------------------------------");
                Console.WriteLine("Amount Withdraw Successfully");
                Console.WriteLine("------------------------------------");
            }
        }

        
    }
}
