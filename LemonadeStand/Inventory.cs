using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables (HAS A)
        public int lemons;
        public int iceCubes;
        public int cups;
        public int sugarCubes;

        // constructor
        public Inventory()
        {
            lemons = 0;
            iceCubes = 0;
            cups = 0;
            sugarCubes = 0;
        }

        // member methods (CAN DO)
        public void DisplayInventory()
        {
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine("You have " + lemons + " Lemons");
            Console.WriteLine("You have " + iceCubes + " IceCubes");
            Console.WriteLine("You have " + cups + " Cups");
            Console.WriteLine("You have " + sugarCubes + "SugarCubes");
            Console.ReadLine();
        }

    }
}
