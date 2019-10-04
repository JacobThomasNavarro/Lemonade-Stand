using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Pitcher
    {
        // member variables (HAS A)
        public int purchaseCup;
        public int oneCup;
        public int remainingLemons;
        public int remainingIceCubes;
        public int remainingSugarCubes;

        // constructor
        public Pitcher(Recipe recipe, Inventory inventory)
        {
            remainingLemons = inventory.lemons.Count - recipe.amountOfLemons;
            remainingIceCubes = inventory.iceCubes.Count - recipe.amountOfIceCubes;
            remainingSugarCubes = inventory.sugarCubes.Count - recipe.amountOfSugarCubes;
        }

        // member methods (CAN DO)


    }
}
