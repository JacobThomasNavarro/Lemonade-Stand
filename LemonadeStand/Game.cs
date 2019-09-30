using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        // member variables (HAS A)
        Player player;
        List<Day> days;
        int currentDay;

        // constructor
        public Game()
        {

        }
        
        // member methods (CAN DO)
        public void RunGame() // master method
        {
            DisplayRules();


        }
        public void DisplayRules()
        {
            Console.WriteLine("You have 7 days to make your Lemonade stand as profitable as possible. Buy your ingredients, set your recipe, and start selling!");
            Console.WriteLine("Start with the default recipe and change according to weather, price and customer interest.");
            Console.WriteLine("Make sure to check the weather forecast before setting your recipe and price per cup!");
        }
        public void PlayTime()
        {
            Console.WriteLine("You will be playing for 7 days.");
        }
    }
}
