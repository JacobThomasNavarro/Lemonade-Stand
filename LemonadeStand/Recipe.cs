using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Recipe
    {
        // member variables (HAS A)
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        // constructor
        public Recipe()
        {
            int amountOfLemons = 0;
            int amountOfSugarCubes = 0;
            int amountOfIceCubes = 0;
            double pricePerCup = 0;
        }

        // member methods (CAN DO)
        public void TheRecipe(Player player)
        {
            UserInterface.BuildRecipe();
            double cupPrice = UserInterface.PricePerCup();
            pricePerCup = cupPrice;
            Console.ReadLine();

            int lemons = UserInterface.LemonsPerPitcher();
            amountOfLemons = lemons;
            Console.ReadLine();

            int sugar = UserInterface.SugarPerPitcher();
            amountOfSugarCubes = sugar;
            Console.ReadLine();

            int ice = UserInterface.IcePerCup();
            amountOfIceCubes = ice;
            Console.ReadLine();

        }
    }
}
