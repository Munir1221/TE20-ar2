using System;

namespace BoolskaOperationer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Åldersgränser i sverige");

            System.Console.Write("Hur gammal är du?");
            int ålder = int.Parse(Console.ReadLine());

            //Om man är 15 och äldre
            if (ålder >= 15)
            {
               Console.WriteLine("Du får köra moped"); 
            }

            // Om man är 18 eller äldre
           if (ålder >= 18)
           {
               Console.WriteLine("Du får köra bil");
           } 


            {
                
            }
            {
                
            }
        }
    }
}
