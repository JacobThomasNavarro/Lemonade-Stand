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
        public Store store;
        List<Day> days;
        int currentDay;

        // constructor
        public Game()
        {
            Inventory inventory = new Inventory();
        }
        
        // member methods (CAN DO)
        public void RunGame() // master method
        {
            UserInterface.DisplayRules();

            int numberOfPlayers = GetNumberOfPlayers();

            CreatePlayers(numberOfPlayers);

            playerOne.ChooseName();

            UserInterface.PlayTime();

            UserInterface.DisplayInventory(playerOne.inventory);

            store = new Store(playerOne);
            store.TheStore();
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
