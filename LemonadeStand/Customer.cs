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
        double temperatureProbability;
        double conditionProbability;
        double purchaseProbability;
        double totalProbability;
        public Random rng;

        // constructor
        public Customer()
        {
            names = new List<string>() {};
            rng = new Random();
        }

        // member methods (CAN DO)
        public void TemperatureCondition(Weather weather)
        {
            if (weather.temperature < 65)
            {
                temperatureProbability = 1;
            }
            else if (weather.temperature >= 65 && weather.temperature <= 85)
            {
                temperatureProbability = 2;
            }
            else if(weather.temperature > 85)
            {
                temperatureProbability = 3;
            }
        }
        public void WeatherCondition(Weather weather)
        {
            if (weather.condition == "Rain")
            {
                conditionProbability = .5;
            }
            else if (weather.condition == "Wind")
            {
                conditionProbability = 1;
            }
            else if(weather.condition == "Cloudy")
            {
                conditionProbability = 1.5;
            }
            else if(weather.condition == "Sunny")
            {
                conditionProbability = 3;
            }
        }
        public void PurchaseCondition(Recipe recipe)
        {
            if (recipe.pricePerCup <= .25)
            {
                purchaseProbability = 5;
            }
            else if(recipe.pricePerCup >= .25 && recipe.pricePerCup <= .50)
            {
                purchaseProbability = 3;
            }
            else if(recipe.pricePerCup > .50)
            {
                purchaseProbability = 1;
            }
        }
        public bool TheDecision()
        {
            totalProbability = (temperatureProbability + conditionProbability + purchaseProbability);
            if(totalProbability > 6)
            {
                if(rng.Next(40, 100) > 50)
                {
                    return true;
                }
                return false;
            }
            else if(totalProbability >= 3)
            {
                if(rng.Next(20, 100) > 50)
                {
                    return true;
                }
                return false;
            }
            else
            {
                if (rng.Next(0, 100) > 50)
                {
                    return true;
                }
                return false;
            }
        }

    }
}
