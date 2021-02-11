using System;
using IronNinja.Interfaces;


namespace IronNinja.Models
{
    public class SweetTooth : Ninja {
        public SweetTooth() : base() {}

        public override bool isFull {
            get {
                if (calorieIntake > 1500) {
                    return true;
                }
                return false;
            }
        }
        public override void Consume(IConsumable item)
        {
            if (isFull == false) {
                if (item.IsSweet == true) {
                    calorieIntake += 10;
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