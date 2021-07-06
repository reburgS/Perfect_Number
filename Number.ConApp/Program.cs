using System;

namespace Number.ConApp
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Console.WriteLine(" Number-App! ");

            //Eingabe(E)
            string input;
            long number;
            do
            {
                Console.WriteLine("GebenSie eine Zahl ein");
                input = Console.ReadLine();
            } while (long.TryParse(input,out number )== false);
            //Verarbeitung(V)
            string output;
            if(Number.Logic.NumberPropertie.IsPerfect(number))
            {
                output = "Es ist eine perfekte Zahl.";   
            }
            else
            {
                output = "Es ist keine pefekte Zahl. ";
            }
            Console.WriteLine(output);
            // Ausgabe(A)
        }
    }
}
