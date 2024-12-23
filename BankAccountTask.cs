using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankaccount = new BankAccount(81365, 100000);
            Console.WriteLine("Deposit...");
            bankaccount.deposit(500);
            Console.WriteLine("Withdraw...");
            bankaccount.withdraw(1000);

            Console.ReadKey();


        }
    }
    class BankAccount
    {
        public int AccountNumer { get; set; }
        private double Balance;
        private readonly object _lock = new object();

        public BankAccount(int accountnumber,double balance)
        {
            AccountNumer = accountnumber;
            Balance = balance;
        }
        public void deposit(double amount)
        {
            lock (_lock)
            {
                Balance += amount;
                Console.WriteLine("Amount of deposit: {0} , Balance become: {1}", amount, Balance);
            }
        }
        public void withdraw(double amount)
        {
            if(Balance >= amount)
            {
                lock (_lock)
                {
                    Balance -= amount;
                    Console.WriteLine("Amount of withdraw: {0} , Balance become: {1}", amount, Balance);
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance...");
            }

        }
        public double getBalance()
        {
            lock (_lock)
            {
                return Balance;
            }
           
        }

    }


}
