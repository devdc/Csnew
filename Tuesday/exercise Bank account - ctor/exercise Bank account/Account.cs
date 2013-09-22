using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_Bank_account
{
    class Account
    {
        private double _Balance;
        public double Balance
        {
            get
            { return _Balance; }
        }

        public void Deposit(double amount)
        {
            _Balance += amount;
        }
        public void WithDraw(double amount)
        {
            _Balance -= amount;
        }

        public Account()
        {
            if (DateTime.Now.Day<16)
            {
                _Balance = 1000;
               // Deposit(1000);
            }
        }

    }
}
