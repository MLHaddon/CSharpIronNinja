using System;
using System.Collections.Generic;

namespace IronNinja.Models
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja() {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool isFull {
            get {
                if (calorieIntake > 1200) {
                    return true;
                }
                return false;
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            if (isFull == false) {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                Console.WriteLine($"Name: {item.Name}\n Is it Spicy?: {item.IsSpicy}\n Is it Sweet?: {item.IsSweet}");
            }
            else {
                Console.WriteLine("This ninja is full.");
            }
        }
    }
}