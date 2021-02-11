using System;
using IronNinja.Models;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet myBuffet = new Buffet();
            Ninja myNinja = new Ninja();
            do { // Continue eating until full
                myNinja.Eat(myBuffet.Serve());
            } while (myNinja.isFull == false);
            myNinja.Eat(myBuffet.Serve()); // Eat one more time to console log that the ninja is full
        }
    }
}
