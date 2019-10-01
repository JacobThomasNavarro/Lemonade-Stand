using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // member variables (HAS A)
        Player player;

        // constructor


        // member methods (CAN DO)
        public void BuyCups()
        {
            Console.WriteLine("How many Cups would you like to purchase?");
            Console.WriteLine("25 paper cups for $0.77");
            Console.WriteLine("50 paper cups for $1.69");
            Console.WriteLine("100 paper cups for $2.94");
            string cups = Console.ReadLine();

            switch (cups)
            {
                case "25":
                    Console.WriteLine("Adding 25 paper cups.");
                    break;
                case "50":
                    Console.WriteLine("Adding 50 paper cups.");
                    break;
                case "100":
                    Console.WriteLine("Adding 100 paper cups.");
                    break;
            }
        }

    }
}
