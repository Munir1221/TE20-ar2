using System;

namespace LuckText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? ");
            string namn = Console.ReadLine();
            
            Console.Write("Hur gammal är du? ");
            string ålder = Console.ReadLine();
            
            Console.Write("Vart bor du? ");
            string område = Console.ReadLine(); 
            
            Console.WriteLine($"Du heter {namn} Du bor i {område} Du är {ålder} år");
        }
    }
}