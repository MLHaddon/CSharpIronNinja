using System;
using IronNinja.Interfaces;

namespace IronNinja.Models
{
    public class SpiceHound : Ninja {
        public SpiceHound() : base() {}
        public override bool isFull {
            get {
                if (calorieIntake > 1200) {
                    return true;
                }
                return false;
            }
        }
        public override void Consume(IConsumable item)
        {
            if (isFull == false) {
                if (item.IsSpicy == true) {
                    calorieIntake -= 5;
                }
                calorieIntake += item.Calories;
                History.Add(item);
                item.GetInfo();
            }
            else {
                Console.WriteLine("This ninja is full.");
            }
        }
    }
}