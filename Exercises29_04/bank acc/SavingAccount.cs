using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_acc
{
    public class SavingAccount : IBankAccount
    {
        private decimal _balance;
        private decimal _perDayLimit;


        

        public bool Deposit(decimal amount)
        {
            _balance += amount;
            return true;
        }

        public bool Withdraw(decimal amount)
        {
            if(_balance < amount) {
                Console.WriteLine("Insufficient balance!");
                return false;
            }else if(_perDayLimit+amount > 5000) {
                Console.WriteLine("Withdrawal attempt failed!");
                return false;
            }
            else
            {
                _balance -= amount;
                _perDayLimit += amount;
                Console.WriteLine(String.Format("Successfully withdraw: {0,6:C}", amount));
                return true;
            }

        }

        public decimal Balance
        {
            get { return _balance; }

        }
        public override string ToString()
        {
            return String.Format("Saving Account Balance = {0,6:C}", _balance);
        }
    }
}
