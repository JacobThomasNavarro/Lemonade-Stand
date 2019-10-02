using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Wallet
    {
        // member variables (HAS A)
        private double money;
        // write a property here to access private money

        public double Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }
        // constructor
        public Wallet()
        {
            money = 20.00;
        }
        // member methods (CAN DO)

    }
}
