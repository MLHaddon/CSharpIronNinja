using System;
using System.Collections.Generic;
using IronNinja.Interfaces;

namespace IronNinja.Models
{
    public abstract class Ninja
    {
        protected int calorieIntake;
        public int CalorieIntake {
            get {
                return calorieIntake;
            }
        }
        public List<IConsumable> History;
        
        // add a constructor
        public Ninja() {
            calorieIntake = 0;
            History = new List<IConsumable>();
        }
        // add a public "getter" property called "IsFull"
        public abstract bool isFull {get;}
        // build out the Eat method
        public abstract void Consume(IConsumable item);
    }
}