using System;

namespace Uppgift_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vilket år är det i år? ");

            int år = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Om 20 år är det {år + 20}");
        }
    }
}
