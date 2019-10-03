using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        // member variables (HAS A)
        Player player;

        // constructor
        public Store(Player playerPassingIn)
        {
            player = playerPassingIn;
        }
        // member methods (CAN DO)
        private void BuyCups()
        {
            Console.WriteLine("How many Cups would you like to purchase?");
            Console.WriteLine("25 paper cups for $0.77");
            Console.WriteLine("50 paper cups for $1.69");
            Console.WriteLine("100 paper cups for $2.94");
            string cups = Console.ReadLine();
            player.inventory.cups.Add(new Cup());

            switch (cups)
            {
                case "25":
                    if (player.wallet.Money >= .77)
                    {
                        player.wallet.Money -= .77;
                        for (int i = 0; i < 25; i++)
                        {
                            player.inventory.cups.Add(new Cup());
                        }
                        Console.WriteLine("Adding 25 paper cups.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
                case "50":
                    if (player.wallet.Money >= 1.69)
                    {
                        player.wallet.Money -= 1.69;
                        for (int i = 0; i < 50; i++)
                        {
                            player.inventory.cups.Add(new Cup());
                        }
                        Console.WriteLine("Adding 50 paper cups.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
                case "100":
                    if (player.wallet.Money >= 2.94)
                    {
                        player.wallet.Money -= 2.94;
                        for (int i = 0; i < 100; i++)
                        {
                            player.inventory.cups.Add(new Cup());
                        }
                        Console.WriteLine("Adding 100 paper cups.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
            }
            TheStore();
        }
        private void BuyLemons()
        {
            Console.WriteLine("How many Lemons would you like to purchase?");
            Console.WriteLine("10 lemons for $0.60");
            Console.WriteLine("30 lemons for $2.27");
            Console.WriteLine("75 lemons cups for $4.37");
            string lemons = Console.ReadLine();

            switch (lemons)
            {
                case "10":
                    if (player.wallet.Money >= .60)
                    {
                        player.wallet.Money -= .60;
                        for (int i = 0; i < 10; i++)
                        {
                            player.inventory.lemons.Add(new Lemon());
                        }
                        Console.WriteLine("Adding 10 lemons.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
                case "30":
                    if (player.wallet.Money >= 2.27)
                    {
                        player.wallet.Money -= 2.27;
                        for (int i = 0; i < 30; i++)
                        {
                            player.inventory.lemons.Add(new Lemon());
                        }
                        Console.WriteLine("Adding 30 lemons.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
                case "75":
                    if (player.wallet.Money >= 4.37)
                    {
                        player.wallet.Money -= 4.37;
                        for (int i = 0; i < 75; i++)
                        {
                            player.inventory.lemons.Add(new Lemon());
                        }
                        Console.WriteLine("Adding 75 lemons.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
            }
            TheStore();
        }
        private void BuySugar()
        {
            Console.WriteLine("How many SugarCubes would you like to purchase?");
            Console.WriteLine("8 cups of sugar for $0.64");
            Console.WriteLine("20 cups of sugar for $1.66");
            Console.WriteLine("48 cups of sugar for $3.45");
            string sugar = Console.ReadLine();

            switch (sugar)
            {
                case "8":
                    if (player.wallet.Money >= .64)
                    {
                        player.wallet.Money -= .64;
                        for (int i = 0; i < 8; i++)
                        {
                            player.inventory.sugarCubes.Add(new SugarCube());
                        }
                        Console.WriteLine("Adding 8 cups of sugar.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
                case "20":
                    if (player.wallet.Money >= 1.66)
                    {
                        player.wallet.Money -= 1.66;
                        for (int i = 0; i < 20; i++)
                        {
                            player.inventory.sugarCubes.Add(new SugarCube());
                        }
                        Console.WriteLine("Adding 20 cups of sugar.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
                case "48":
                    if (player.wallet.Money >= 3.45)
                    {
                        player.wallet.Money -= 3.45;
                        for (int i = 0; i < 48; i++)
                        {
                            player.inventory.sugarCubes.Add(new SugarCube());
                        }
                        Console.WriteLine("Adding 48 cups of sugar.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
            }
            TheStore();
        }
        private void BuyIce()
        {
            Console.WriteLine("How many IceCubes would you like to purchase?");
            Console.WriteLine("100 ice cubes for $0.86");
            Console.WriteLine("250 ice cubes for $2.14");
            Console.WriteLine("500 ice cubes for $3.58");
            string ice = Console.ReadLine();

            switch (ice)
            {
                case "100":
                    if (player.wallet.Money >= .86)
                    {
                        player.wallet.Money -= .86;
                        for (int i = 0; i < 100; i++)
                        {
                            player.inventory.iceCubes.Add(new IceCube());
                        }
                        Console.WriteLine("Adding 100 ice cubes.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
                case "200":
                    if (player.wallet.Money >= 2.14)
                    {
                        player.wallet.Money -= 2.14;
                        for (int i = 0; i < 200; i++)
                        {
                            player.inventory.iceCubes.Add(new IceCube());
                        }
                        Console.WriteLine("Adding 200 ice cubes.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
                case "500":
                    if (player.wallet.Money >= 3.58)
                    {
                        player.wallet.Money -= 3.58;
                        for (int i = 0; i < 500; i++)
                        {
                            player.inventory.iceCubes.Add(new IceCube());
                        }
                        Console.WriteLine("Adding 500 ice cubes.");
                    }
                    else
                    {
                        Console.WriteLine("You don't have enough money!");
                    }
                    break;
            }
            TheStore();
        }
        public void TheStore()
        {
                UserInterface.GetUserInput();
                int choice = UserInterface.GetMenuOption();

            switch (choice)
            {
                case 1:
                    BuyCups();
                    break;

                case 2:
                    BuyLemons();
                    break;

                case 3:
                    BuySugar();
                    break;

                case 4:
                    BuyIce();
                    break;
                case 5:
                    return;
            }
            Console.ReadLine();
        }
    }
}
