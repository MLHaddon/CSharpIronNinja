using System;
using IronNinja.Interfaces;

namespace IronNinja.Models
{
    public class Drink : IConsumable
    {
        public string Name {get;set;}
        public int Calories {get;set;}
        public bool IsSpicy {get;set;}
        public bool IsSweet {get;set;}
        public string GetInfo()
        {
        return $"{Name} (Drink).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}";
        }

        public Drink(string name, int Cal, bool spicy) {
            Name = name;
            Calories = Cal;
            IsSpicy = spicy;
            IsSweet = true;
        }
    }
}