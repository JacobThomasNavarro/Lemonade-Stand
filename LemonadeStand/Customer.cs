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

        // constructor
        public Customer()
        {
            names = new List<string>() {};
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
        public void TheDecision()
        {
            totalProbability = (temperatureProbability + conditionProbability + purchaseProbability);
            if(totalProbability > 6)
            {

            }
            else if(totalProbability >= 3 && totalProbability <= 6)
            {

            }
            else if(totalProbability < 3)
            {

            }
        }

    }
}
