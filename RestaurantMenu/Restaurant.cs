using System;

namespace RestaurantMenu
{
    class Restaurant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to restaurant menu.");
            int userSelection;
            Menu myMenu = new Menu();
            while (true)
            {
                Console.Write("What would you like to do?\n1 - Add menu Item\n2 - Remove menu item\n3 - Print Menu\n>");
                while(!int.TryParse(Console.ReadLine(), out userSelection))
                {
                     Console.WriteLine("Invalid input.");
                }
                if (userSelection == 1)
                {
                    myMenu.AddMenuItem();
                }
                else if (userSelection == 2)
                {
                    myMenu.RemoveMenuItem();
                }
                else if (userSelection == 3)
                {
                    Console.WriteLine(myMenu.ToString());
                } else
                {
                    Console.WriteLine("Not a valid Selection.");
                }


                }

            }
    }
}
