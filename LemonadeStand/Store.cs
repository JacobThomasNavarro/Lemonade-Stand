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
            string gesture = Console.ReadLine();

            switch (gesture)
            {
                case "rock":
                    Console.WriteLine("Humany player chose " + gesture);
                    break;
                case "paper":
                    Console.WriteLine("Humany player chose " + gesture);
                    break;
                case "scissors":
                    Console.WriteLine("Humany player chose " + gesture);
                    break;
                case "lizard":
                    Console.WriteLine("Humany player chose " + gesture);
                    break;
                case "spock":
                    Console.WriteLine("Humany player chose " + gesture);
                    break;
            }
        }

    }
}
