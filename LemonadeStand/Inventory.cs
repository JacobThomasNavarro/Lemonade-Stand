using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        // member variables (HAS A)
        public List<Lemon> lemons;
        public List<IceCube> iceCubes;
        public List<Cup> cups;
        public List<SugarCube> sugarCubes;

        // constructor
        public Inventory()
        {
            lemons = new List<Lemon>() { };
            iceCubes = new List<IceCube>() { };
            cups = new List<Cup>() { };
            sugarCubes = new List<SugarCube>() { };
        }

        // member methods (CAN DO)
        

        public void ChooseMenuOption()
        {
         
            int choice = UserInterface.GetMenuOption();
            switch (choice)
            {
                case 1:
                    // Do this shit
                    break;
                case 2:
                    //do this
                    break;
            }
        }

    }
}
