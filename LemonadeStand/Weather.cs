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

        // constructor
        public Weather()
        {
            temperatureForecast = new List<int>() { 55, 60, 65, 70, 75, 80, 85, 90, 95 };
            weatherConditions = new List<string>() { "Rain", "Wind", "Sunny", "Cloudy" };
            rng = new Random();
        }

        // member methods (CAN DO)
        public void ForecastTemperature()
        {
            int index = rng.Next(temperatureForecast.Count);
            Console.WriteLine("Temperature Forecast " + temperatureForecast[index]);
            temperature = temperatureForecast[index];
            Console.ReadLine();
        }
        public void ForecastCondition()
        {
            int index = rng.Next(weatherConditions.Count);
            Console.WriteLine("Weather Forecast " + weatherConditions[index]);
            condition = weatherConditions[index];
            Console.ReadLine();
        }

    }
}
