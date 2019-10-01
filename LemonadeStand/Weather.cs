using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        // member variables (HAS A)
        public string condition;
        public int temperature;
        private List<int> temperatureForecast;
        private List<string> weatherConditions;
        public Random rng;
        //public string predicatedForecast;

        // constructor
        public Weather()
        {
            temperatureForecast = new List<int>() { 60, 65, 70, 75, 80, 85, 90, 95 };
            weatherConditions = new List<string>() { "Rainy", "Cool", "Hot", "Sunny", "Humid", "Cloudy" };
            rng = new Random();
        }

        // member methods (CAN DO)
        public void ForecastTemperature()
        {
            int index = rng.Next(temperatureForecast.Count);
            Console.WriteLine("Temperature Forecast " + temperatureForecast[index]);
            temperature = temperatureForecast[index];
        }
        public void ForecastCondition()
        {
            int index = rng.Next(weatherConditions.Count);
            Console.WriteLine("Weather Condition Forecast " + weatherConditions[index]);
            condition = weatherConditions[index];
        }

    }
}
