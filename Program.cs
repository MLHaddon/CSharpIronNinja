using System;
using IronNinja.Models;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet myBuffet = new Buffet();
            SweetTooth sweetTooth = new SweetTooth();
            SpiceHound spiceHound = new SpiceHound();
            int count1 = 0;
            int count2 = 0;

            while (sweetTooth.isFull == false) {
                sweetTooth.Consume(myBuffet.Serve());
                count1++;
            }

            while (spiceHound.isFull == false) {
                spiceHound.Consume(myBuffet.Serve());
                count2++;
            }

            if (count1 > count2) {
                Console.WriteLine($"SweetTooth consumed the most with {count1} items consumed.");
            } else if (count2 > count1) {
                Console.WriteLine($"SpiceHound consumed the most with {count2} items consumed.");
            } else {
                Console.WriteLine($"Both Ninjas consumed {count1} items.");
            }
        }
    }
}
