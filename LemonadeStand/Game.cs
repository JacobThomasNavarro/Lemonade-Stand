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
        public Player playerOne;
        public Player playerTwo;
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

            int numberOfPlayers = GetNumberOfPlayers();

            CreatePlayers(numberOfPlayers);

            playerOne.ChooseName();

            PlayTime();
            
        }
        public void DisplayRules()
        {
            Console.WriteLine("You have 7 days to make your Lemonade stand as profitable as possible. Buy your ingredients, set your recipe, and start selling!");
            Console.WriteLine("Start with the default recipe and change according to weather, price and customer interest.");
            Console.WriteLine("Make sure to check the weather forecast before setting your recipe and price per cup!");
        }
        public void PlayTime()
        {
            Console.WriteLine("Your 7 days of business start now. Good luck!");
        }
        public int GetNumberOfPlayers()
        {
            Console.WriteLine("How many players?");
            int numberOfPlayers = int.Parse(Console.ReadLine());
            return numberOfPlayers;
        }
        public void CreatePlayers(int numberOfPlayers)
        {
            if (numberOfPlayers == 1)
            {
                playerOne = new Player();
            }
        }
    }
}
