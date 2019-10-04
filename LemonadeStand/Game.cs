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
        public Day day;
        public Customer customers;

        // constructor
        public Game()
        {
            Inventory inventory = new Inventory();
            days = new List<Day>();
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

            PlayGame();

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
        public void PlayGame()
        {
            UserInterface.DisplayInventory(playerOne.inventory);
            Console.ReadLine();

            store = new Store(playerOne);
            store.TheStore();

            weather = new Weather();
            weather.ForecastTemperature();
            weather.ForecastCondition();

            recipe = new Recipe();
            recipe.TheRecipe(playerOne);

            AddDays();

            day = new Day();
            day.AddCustomers();

            for (int i = 0; i < days.Count; i++)
            {
                for(int j = 0; j < day.customers.Count; j++)
                {
                    customers = new Customer();
                    customers.TheDecision();
                }
            }
        }
        public void AddDays()
        {
            for (int i = 0; i < 7; i++)
            {
                days.Add(new Day());
            }
        }
    }
}
