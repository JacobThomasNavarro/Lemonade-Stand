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
        public Recipe recipe;
        List<Day> days;
        int currentDay;
        public Weather weather;

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
            Console.ReadLine();

            
            UserInterface.DisplayInventory(playerOne.inventory);
            Console.ReadLine();

            store = new Store(playerOne);
            store.TheStore();

            weather = new Weather();
            weather.ForecastTemperature();
            weather.ForecastCondition();

            recipe = new Recipe();
            recipe.TheRecipe(playerOne);

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
        public void PlayGame(Recipe theRecipe, Inventory inventory)
        {
            //while (recipe.amountOfLemons <=  inventory.lemons && recipe.amountOfIceCubes <= inventory.iceCubes && inventory.sugarCubes <= recipe.amountOfSugarCubes) ;
        }
    }
}
