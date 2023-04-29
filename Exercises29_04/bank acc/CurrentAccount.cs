using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank_acc
{
    public class CurrentAccount : IBankAccount
    {
           private decimal _balance;
    public bool Deposit(decimal amount)
    {
	        _balance += amount;
	        return true;
	    }
	    public bool Withdraw(decimal amount)
	    {
	        if (_balance<amount)
        {
	            Console.WriteLine("Insufficient balance!");
	            return false;
	        }
            else
                       {
                _balance -= amount;
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
             return String.Format("Current Account Balance = {0,6:C}", _balance);
         } }


    }

