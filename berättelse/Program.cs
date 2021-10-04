using System;

namespace berättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Är du vuxen? (yes/no)");
            string vuxen = Console.ReadLine();

            if (vuxen == "yes")
            {
               Console.WriteLine("Har du tagit studentexamen? (yes/no)"); 
               string examen = Console.ReadLine();
               if (examen == "yes")
               {
                   Console.WriteLine("Har du ett jobb?");
                   string job = Console.ReadLine();
                   if (job == "no")
                   {
                       Console.WriteLine("Försök att ta studentexamen? (yes/no)");
                   }
                   else
                   {
                       Console.WriteLine("Vill du ha ett jobb? (yes/no)");
                
                   }
               }
               else
               {
                   Console.WriteLine("Vill du göra det? (yes/no)");
                   string student = Console.ReadLine();
                
               }
            }
            else
            {
                Console.WriteLine("Har du en vuxen bredvid dig? yes/no");
                 vuxen = Console.ReadLine();
                if (vuxen == "no" )
                {
                    Console.WriteLine("Du behöver en vuxen för att svara på följande frågor");
                }
                else
                {
                    Console.WriteLine("Svara på frågorna noggrant");
                }
            }
            
        }
    }
}
