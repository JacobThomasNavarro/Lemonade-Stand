using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        // member variables (HAS A)
        private List<string> names;
        public string name;
        double weatherChances;
        double temperatureChances;
        int strongChance;
        int lowChance;

        // constructor
        public Customer()
        {
            names = new List<string>() {};
        }

        // member methods (CAN DO)
        public void TemperatureCondition(Weather weather)
        {
            if(weather.temperature < 75)
            {

            }
        }

    }
}
