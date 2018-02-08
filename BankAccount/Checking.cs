using System;

namespace BankAccount
{
    public class Checking : Account
    {
        // Field
        private double minBalance;
        private double maxBalance;


        // Properties
        public double MinBalance
        {
            get { return minBalance;  }
        }
        
        public double MaxBalance
        {
            get { return maxBalance;  }
        }

        // Constructors


        //public Checking(double balance) :base ()
        //{
        //    this.minBalance = 500;
        //    this.maxBalance = 10000;
        //    this.balance = blance;
        //    acc
        //}
    }
}
