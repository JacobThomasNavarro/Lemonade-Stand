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
        public int cupsInPitcher;

        // constructor
        public Pitcher(Recipe recipe, Inventory inventory)
        {
            remainingLemons = inventory.lemons.Count - recipe.amountOfLemons;
            remainingIceCubes = inventory.iceCubes.Count - recipe.amountOfIceCubes;
            remainingSugarCubes = inventory.sugarCubes.Count - recipe.amountOfSugarCubes;
            cupsInPitcher = 12;
            oneCup = recipe.amountOfLemons + recipe.amountOfIceCubes + recipe.amountOfSugarCubes;
        }

        // member methods (CAN DO)
        public int CreatePitcher()
        {
            if()
        }
        // have a method here that is CreatePticher
        //in this method take away inventory IF the player has enough inventory for another pitcher
        // every time you create a new pitcher set the amountOfCups 




    }
}
