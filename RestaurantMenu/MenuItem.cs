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
        
        // Price setter validates non-negative price input
        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Price cannot be negative");
                }
            }
        }

        // Category setter validates input to be one of { Appetizer, Main Course, Dessert }
        public string Category
        {
            get { return category; }
            set
            {
                if (Menu.ItemCategories.Contains(value.ToLower()))
                {
                    category = value;
                }
                else
                {
                    Console.WriteLine("Category must be Appetizer, Dessert, or Main Course.");
                }
            }
        }

        // Default constructor
        public MenuItem() { }

        // Fully defined constructor
        public MenuItem(string name, string description, double price, string category, bool newItem = false)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            NewItem = newItem;
        }

        // To String for menu display
        public override string ToString()
        {
            return $"{Name} / {Description} / {Price:C2} {(NewItem ? "/ New Item!" : "")}";
        }

        // Equals() compares name and category
        public override bool Equals(object obj)
        {
            return obj is MenuItem item &&
                   Name == item.Name &&
                   Category == item.Category;
        }

        // GetHashCode relies on name and category
        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Category);
        }
    }
}
