namespace Banking_System
{
    internal class Program
    {
        static string Name;
        static long acc;
        static double Balance = 0.0;
        static string accType;
        

        static void createAccount()
        {
            Console.WriteLine("Enter your Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Account Type : ");
            accType = Console.ReadLine();
            Console.WriteLine("Enter Account Number");
            acc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Account has been created!");
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            bool fl = true;
            while (fl) {

                Console.WriteLine("----------Wellcome to Shashi Bank---------");
                Console.WriteLine("1. Create a new Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Display account detail");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your option :");

                //Reading the string input from the console
                string input = Console.ReadLine();

                int options;
                if (int.TryParse(input, out options) && options <=5 && options >0)
                {
                    switch (options)
                    {
                        case 1:
                            createAccount();
                            break;
                        case 2:
                            depositeMoney();
                            break;
                        case 3:
                            withdrawMoney();
                            break;
                        case 4:
                            display();
                            break;
                        case 5:
                            fl = false;
                            break;
   
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number from 1 to 5.");
                }
            }
        }

        static void depositeMoney()
        {
            Console.WriteLine("Enter your Account number : ");
            int account = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount to Deposite : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (account == acc)
            {
                Balance += amount;
                Console.WriteLine("Amount Deposited Successfully");
            }
            else
            {
                Console.WriteLine("Please Enter Valid Acount Number! ");
            }
        }
        static void withdrawMoney()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Enter your Account Number : ");

            int account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount to Withdraw : ");
            int amount = Convert.ToInt32(Console.ReadLine());

            if(account == acc)
            {
                Balance -= amount;
                Console.WriteLine("Amount Withdraw Successfully");
                Console.WriteLine("------------------------------------");
            }
        }
        
        static void display()
        {
            Console.WriteLine("Enter you Account number : ");
            int account = Convert.ToInt32(Console.ReadLine());
            if(account == acc)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("Account Number : " + acc);
                Console.WriteLine("Account Type : " + accType);
                Console.WriteLine("Balance Amount : " + Balance);
                Console.WriteLine("------------------------------------");
            }
            else
            {
                Console.WriteLine("No" + account + " Found Please Enter Valid Account Number");
            }
         }
    }
}
