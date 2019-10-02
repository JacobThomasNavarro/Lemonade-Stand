﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static class UserInterface
    {
        public static void GetUserInput()
        {
            Console.WriteLine("What would you like to purchase?");
        }
        public static int GetMenuOption()
        {
            Console.WriteLine("Choose an option\n1)Cups\n2)Lemon\n3)Sugar\n4)Ice");
            int choice = Int32.Parse(Console.ReadLine());
            return choice;
        }
        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Current Inventory: ");
            Console.WriteLine("You have " + inventory.lemons.Count + " Lemons");
            Console.WriteLine("You have " + inventory.iceCubes.Count + " IceCubes");
            Console.WriteLine("You have " + inventory.cups.Count + " Cups");
            Console.WriteLine("You have " + inventory.sugarCubes.Count + " SugarCubes");
        }
        public static void DisplayRules()
        {
            Console.WriteLine("You have 7 days to make your Lemonade stand as profitable as possible. Buy your ingredients, set your recipe, and start selling!");
            Console.WriteLine("Start with the default recipe and change according to weather, price and customer interest.");
            Console.WriteLine("Make sure to check the weather forecast before setting your recipe and price per cup!");
        }
        public static void PlayTime()
        {
            Console.WriteLine("Your 7 days of business start now. Good luck!");
        }
        public static string StoreRunTime()
        {
            Console.WriteLine("Would you like to keep purchasing? - 'yes' or 'no'");
            string input = Console.ReadLine();
            return input;
        }
        public static void BuildRecipe()
        {
            Console.WriteLine("Program your recipe for this round.");
            Console.WriteLine("Price/Quality Control.");
        }
        //public static int MainMenuOption()
        //{
        //    Console.WriteLine("Choose an option\n1)View Inventory\n2)Visit Store\n3)Sugar\n4)Ice");
        //    int choice = Int32.Parse(Console.ReadLine());
        //    return choice;
        //}
    }
}