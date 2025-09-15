using System.Security.Cryptography;

namespace Banking_System
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Account a1 = new Account();
            bool fl = true;
            while (fl) {

                Console.WriteLine("----------Wellcome to Shashi Bank---------");
                Console.WriteLine("1. Create a new Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Display account detail");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your option :");

                string input = Console.ReadLine();

                int options;
                if (int.TryParse(input, out options) && options <=5 && options >0)
                {
                    switch (options)
                    {
                        case 1:
                            createAccount(a1);
                            break;
                        case 2:
                            depositeMoney(a1);
                            break;
                        case 3:
                            withdrawMoney(a1);
                            break;
                        case 4:
                            displayinfo(a1);
                            break;
                        case 5:
                            fl = false;
                            break;
                        default: Console.WriteLine("Please Enter a valid number between 1 to 5 ");
                            break;

   
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number from 1 to 5.");
                }
            }
        }

        static void createAccount(Account a1)
        {

            Console.WriteLine("Enter your Name : ");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter Account Number");
            long acc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Account Type : ");
            string accType = Console.ReadLine();

            Console.WriteLine("Enter your password : ");
            string password = Console.ReadLine();

            a1.create(acc, Name, accType, 0, password);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Your Account has been created!");
            Console.WriteLine("------------------------------------");
        }

        static void depositeMoney(Account acc)
        {
            Console.WriteLine("Enter your Account number : ");
            int account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Password : ");
            string pass = Console.ReadLine();
            
            if (acc.auth(account, pass))
            {
                Console.WriteLine("Enter Amount to Deposite : ");
                int amount = Convert.ToInt32(Console.ReadLine());
                acc.deposite(amount);

                Console.WriteLine("------------------------------------");
                Console.WriteLine("Amount Deposited Successfully");
                Console.WriteLine("------------------------------------");
            }
            else
            {
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Please Enter Valid Acount Number and password! ");
                Console.WriteLine("-----------------------------------------------------");
            }
        }
        static void withdrawMoney(Account acc)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter your Account Number : ");

            int account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter you password : ");
            string pass = Console.ReadLine();

            if(acc.auth(account, pass))
            {
                Console.WriteLine("Enter Amount to Withdraw : ");
                int amount = Convert.ToInt32(Console.ReadLine());

                acc.withdraw(amount);
                
            }
        }
        
        static void displayinfo(Account acc)
        {
            Console.WriteLine("Enter you Account number : ");
            int account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter you password : ");
            string pass = Console.ReadLine();

            if(acc.auth(account, pass))
            {
                acc.display();
            }
            else
            {
                Console.WriteLine("---------------------------------------------------------------------------------------");
                Console.WriteLine("No Account : " + account + " is found Please Enter Valid Account Number or Correct Password ");
                Console.WriteLine("---------------------------------------------------------------------------------------");
            }
         }
    }
}
