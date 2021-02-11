using System;
using System.Collections.Generic;

namespace IronNinja.Models
{
    public class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Example", 700, false, false),
                new Food("Pizza", 400, true, false),
                new Food("Lazagna", 500, false, false),
                new Food("Ice Cream", 700, false, true),
                new Food("Tacos", 400, true, false),
                new Food("Chocolate", 500, false, true),
                new Food("Strawberries", 200, false, true)
            };
        }
        
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count - 1)];
        }
    }
}