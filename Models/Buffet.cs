using System;
using System.Collections.Generic;
using IronNinja.Interfaces;

namespace IronNinja.Models
{
    public class Buffet
    {
        public List<IConsumable> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<IConsumable>()
            {
                new Food("Example", 700, false, false),
                new Food("Pizza", 400, true, false),
                new Food("Lazagna", 500, false, false),
                new Food("Ice Cream", 700, false, true),
                new Food("Tacos", 400, true, false),
                new Food("Chocolate", 500, false, true),
                new Food("Strawberries", 200, false, true),
                new Drink("Coke", 100, false),
                new Drink("Dr. Pepper", 150, false),
                new Drink("Chocolate Shake", 250, false)
            };
        }
        
        public IConsumable Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count - 1)];
        }
    }
}