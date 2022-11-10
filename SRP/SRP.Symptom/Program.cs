using System;

namespace SRP.Symptom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("George Insurance Rating System Starting...");

            var engine = new RatingEngine();
            engine.Rate();

            if(engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }
        }
    }
}
