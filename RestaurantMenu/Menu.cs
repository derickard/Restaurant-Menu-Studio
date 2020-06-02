using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RestaurantMenu
{
    class Menu
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private DateTime updated = DateTime.Now;
        public static List<string> ItemCategories = new List<string>{ "appetizer", "main course", "dessert" };
        
        public void AddMenuItem()
        {
            MenuItem newItem = new MenuItem();

            Console.Write("Enter new item's name: ");
            newItem.Name = Console.ReadLine();

            Console.Write("Enter new item's description: ");
            newItem.Description = Console.ReadLine();

            string categoryInput;
            do
            {
                Console.Write("Enter new item's category <(A)ppetizer, (M)ain Course, (D)essert: ");
                categoryInput = Console.ReadLine();
                if (categoryInput.ToLower() == "a")
                {
                    categoryInput = "appetizer";
                } else if (categoryInput.ToLower() == "m")
                {
                    categoryInput = "main course";
                } else if (categoryInput.ToLower() == "d")
                {
                    categoryInput = "dessert";
                }
                newItem.Category = categoryInput.ToLower();

            } while (ItemCategories.IndexOf(newItem.Category.ToLower()) < 0);


            Console.Write("Enter new item's price: ");
            double priceInput;
            while (!double.TryParse(Console.ReadLine(), out priceInput))
            {
                Console.Write("Price must be a number, try again: ");
            }
            newItem.Price = priceInput;

            if(ItemExists(newItem))
            {
                Console.Write("Item won't be added, it already exists in the menu as a {0}:  \"{1}\"\n", menu[menu.IndexOf(newItem)].Category, menu[menu.IndexOf(newItem)].ToString());
            } else
            {
                menu.Add(newItem);
                Console.WriteLine("Adding the item: {0}", newItem.ToString());
            } 

        }

        public void RemoveMenuItem()
        {
            string removeName;
            Console.Write("Enter the item name you wish to remove: ");
            removeName = Console.ReadLine();
            foreach(MenuItem item in menu)
            {
                if(Equals(item.Name.ToLower(),removeName.ToLower()))
                {
                    menu.Remove(item);
                    Console.WriteLine("Removing the following item: {0}", item.ToString());
                    return;
                }
            }
            Console.WriteLine("Item not found in menu.  Cannot remove an item that does not exist in menu.");
        }

        private bool ItemExists(MenuItem checkItem)
        {
            if(menu.Any())
            {
                foreach (MenuItem item in menu)
                {
                    if(Equals(item, checkItem))
                    {
                        return true;
                    } 
                }
            }
            return false;
        }
        public override string ToString()
        {
            StringBuilder menuString = new StringBuilder();
            StringBuilder appetizers = new StringBuilder();
            StringBuilder mains = new StringBuilder();
            StringBuilder desserts = new StringBuilder();
            string delim = "-----------------\n";

            foreach(MenuItem item in menu)
            {
                if(Equals(item.Category.ToLower(), ItemCategories[0]))
                {
                    appetizers.Append($"{item.ToString()}\n");
                } else if (Equals(item.Category.ToLower(), ItemCategories[1]))
                {
                    mains.Append($"{item.ToString()}\n");
                } else
                {
                    desserts.Append($"{item.ToString()}\n");
                }
            }
            menuString.Append(delim).Append(ItemCategories[0]).Append("\n").Append(delim).Append(appetizers);
            menuString.Append(delim).Append(ItemCategories[1]).Append("\n").Append(delim).Append(mains);
            menuString.Append(delim).Append(ItemCategories[2]).Append("\n").Append(delim).Append(desserts);
            return menuString.ToString();
        }

    }
}
