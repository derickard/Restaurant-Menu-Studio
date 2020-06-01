using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private string category;
        private double price;
        private readonly List<string> choices = new List<string> { "appetizer", "dessert", "main course" };
        
        public bool NewItem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price {
            get { return price; }
            set
            {
                if(value>0)
                {
                    price = value;
                } else
                {
                    Console.WriteLine("Price cannot be negative");
                }
            } 
        }
        public string Category {
            get { return category; }
            set
            {
                if(this.choices.Contains(value.ToLower()))
                {
                    category = value;
                } else
                {
                    Console.WriteLine("Category must be Appetizer, Dessert, or Main Course.");
                }

            }
        }

    }
}
