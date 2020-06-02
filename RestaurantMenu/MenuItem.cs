using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        private string category;
        private double price;
                
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
                if(Menu.ItemCategories.Contains(value.ToLower()))
                {
                    category = value;
                } else
                {
                    Console.WriteLine("Category must be Appetizer, Dessert, or Main Course.");
                }

            }
        }

        public override string ToString()
        {
            return $"{Name} / {Description} / {Price.ToString("C2")} {(NewItem ? "/ New Item!" : "")}";
        }
        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name &&
                   Category == item.Category;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Category);
        }
    }
}
