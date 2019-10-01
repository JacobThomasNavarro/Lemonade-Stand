using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        public double businessProfits;

        // constructor
        public Player()
        {
            inventory = new Inventory();
        }

        // member methods (CAN DO)
        public void ChooseName()
        {
            Console.WriteLine("Player choose a name.");
            name = Console.ReadLine();
        }

    }
}
