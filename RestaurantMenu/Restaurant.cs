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

            myMenu.AddMenuItem(new MenuItem("Hummus", "Egglant humus with naan", 4.50, "appetizer"));
            myMenu.AddMenuItem(new MenuItem("Cranberry Brie Bites", "Homemade cranberry sauce in a crescent roll with brie", 5.50, "appetizer"));
            myMenu.AddMenuItem(new MenuItem("Cardamom Maple Salmon", "Cardamom and coriander with maple glaze on beautiful wild salmon", 15.95, "main course"));
            myMenu.AddMenuItem(new MenuItem("Shahi Paneer", "Paneer in a tomato-cream sauce", 13.50, "main course"));
            myMenu.AddMenuItem(new MenuItem("Battenburg Cake", "Fancy almond-flavored tea cake", 6.50, "dessert"));
            myMenu.AddMenuItem(new MenuItem("Triple Chocolate Roll Cake", "Chocoloate sponge cake wrapped around alternating stripes of white and dark chocolate", 5.75, "dessert"));

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
