using System;

namespace villkor
{
    class Program
    {
        static void Main(string[] args)
        {
           // Be användaren om ålder
            Console.Write("Hur gammal är du? (heltal)");
            int ålder = int.Parse (Console.ReadLine());
            
            // Om ålder större än 18 "du får ta körkort!"
            if (ålder >=18 )
            {
                Console.WriteLine("Du får ta körkort!");
            }

            // Om åder är 15 eller högre -> "Du får ta mopedkörkort!"
            if (ålder >=15)
             {
                Console.WriteLine("Du får ta mopedkörkort!"); 
            }

            // Fråga användaren "Vad hetter ABBAs senaste låt?"
            Console.WriteLine("Vad hetter ABBAs senaste Album?");
            string låt = Console.ReadLine();
            
            // Är svaret korrekt?
            if (låt == "Voyage")
            {
                Console.WriteLine("Bra svarat!");
            }
            else
            {
                Console.WriteLine("Fel albummet heter Voyage");
            }


            // Sista TP-fråga 
            Console.Write("Vem missade straffen i matchen England-Frankrike? (efternamn)");

            // L´läs in och tvinga till små bokstäver:
            // Mbappe -> mbappe
            // mbappe -> mbappe
          
           String spelare = Console.Redline();
           
            if (spelare == "Mbappe")
            {
                Console.WriteLine("Du är en expert!");
            }
            else
            {
                Console.WriteLine("Fel! Det var Mbappe");
            }


        }
    } 
}
