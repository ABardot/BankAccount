using System;

namespace BankAccount
{
    public abstract class Account // Abstract base class
    {
        // fields
        private double balance = 0;

        private string accountType;
        private double deposit;
        private double withDraw;

        // Properties
        public string AccountType
        {
            get { return this.accountType; }
        }

        public double Bal
        {
            get { return this.balance; }
        }

        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public double WithDraw
        {
            get { return this.withDraw; }
            set { this.withDraw = value; }
        }

        // Constructor

        // Methods

        public virtual double Balance()
        {
            balance = balance + deposit - withDraw;
            deposit = 0;
            withDraw = 0;
            return balance;
        }

        public virtual double BalanceDeposit(double userInput)
        {
            deposit = userInput;
            withDraw = 0;
            balance = balance + deposit - withDraw;
            return balance;
        }

        public virtual double BalanceWithdrawn(double userInput)
        {
            deposit = 0;
            withDraw = userInput;
            balance = balance + deposit - withDraw;
            return balance;
        }

        public virtual void MenuDisplay()
        {
            Console.WriteLine("Welcome to WCCI bank!");
            Console.WriteLine("How can we help you today?");
            Console.WriteLine("Please pick an option.");
            Console.WriteLine("\n");
            Console.WriteLine("1) View Client Information \n2) View Account Balance \n3) Deposit Funds \n4) Withdraw Funds \n5) Exit");
        }

        public virtual string AccountInfo()
        {
            string clientInfo = ("Account Holder: John Doe \nAccount Number: 123456");

            return clientInfo;
        }
    }
}