using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_2
{
   


    class BankAccount:InterfaceObject
    {
        private double _interestRate;
        private double _balance;

        public double InterestRate { get; set; }
        public double Balance { get; set; }

        public BankAccount(double interestRate, double balance)
        {
            this.InterestRate = interestRate;
            this.Balance = balance;
        }

        public double Calculate()
        {
            return (InterestRate/100) * Balance ;
        }

        public override string ToString()
        {
            return "You need to pay " + (InterestRate / 100) * Balance + " € this month"; 
        }


    }
}
