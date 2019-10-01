﻿using System;
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
            double pricePerCup = .25;
        }

        // member methods (CAN DO)
        public void EnterRecipe()
        {
            Console.WriteLine("Please enter this round's recipe.");
            Console.WriteLine("Price per Cup");
            pricePerCup = int.Parse(Console.ReadLine());
            Console.WriteLine("Lemons per Pitcher");
            amountOfLemons = int.Parse(Console.ReadLine());
            Console.WriteLine("Sugar per Pitcher");
            amountOfSugarCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ice per Cup");
            amountOfIceCubes = int.Parse(Console.ReadLine());
        }
    }
}
