using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment1
{
    class bank
    {
        private double balance = 10000;

        public double credit
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    class Index
    {
        bank myBank = new bank();
        string name;
        int account;
        double withdraw, deposit, transfer, totalcredit;



        public void index1()
        {
            Console.WriteLine("Give Name the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Give Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Give Deposit Amount :");
            deposit = Convert.ToDouble(Console.ReadLine());
            totalcredit = myBank.credit + deposit;



            Console.WriteLine("#############################\n");
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + totalcredit);



        }
        public void index2()
        {
            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= myBank.credit)
            {
                totalcredit = myBank.credit - withdraw;
                Console.WriteLine("**************************\n");
                Console.WriteLine("Give Account Name : " + name);
                Console.WriteLine("Give Account Number: " + account);
                Console.WriteLine("Give Withdraw Amount balnace is : " + totalcredit);
            }
            else
                Console.WriteLine("\n\nWithdraw Ammount does not Exist your Account.");
        }
        public void index3()
        {
            Console.WriteLine("Enter Name of the transferer :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Transfer Amount :");
            deposit = Convert.ToDouble(Console.ReadLine());
            totalcredit = myBank.credit + deposit;



            Console.WriteLine("##########################\n");
            Console.WriteLine("Name of the transferer : " + name);
            Console.WriteLine("Give Your Account Number: " + account);
            Console.WriteLine("Total Balance amount : " + totalcredit);



        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char check;
            do
            {
                Index A = new Index();
                int num;
                Console.WriteLine("Choose any Option: ");
                Console.WriteLine("\n 1 for Deposit Amount \n 2 for Withdraw Amount \n 3 for Transfer Amount");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        A.index1();
                        break;
                    case 2:
                        A.index2();
                        break;
                    case 3:
                        A.index3();
                        break;
                    default:
                        Console.WriteLine("Wrong Selection,Please select correct option !");
                        break;
                }
                Console.WriteLine("\n Do you want to Again Execute this program? (y/n)");
                check = Convert.ToChar(Console.ReadLine());



            } while (check == 'y');



            Console.ReadKey();
        }
    }
}