using System;

namespace uppgift_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur högt hoppar du?");
            float höjd = float.Parse(Console.ReadLine());

            Console.WriteLine($"Du har {2.45 - höjd} meter till 2,45");
            
        }
    }
}
