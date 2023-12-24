using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectHome
{
    public class CollectionsPractice
    {

        public delegate double InterestCalculator(double principal, double rate, int years);

        public class BankAccount
        {
            private InterestCalculator interestCalculator;

            public double Balance { get; }

            public BankAccount(double balance, InterestCalculator calculatorType)
            {
                this.Balance = balance;
                interestCalculator = calculatorType;
            }

            public double CalculateFinalAmount(int years)
            {
                return interestCalculator(Balance, 0, years);
            }
        }



    }

}
