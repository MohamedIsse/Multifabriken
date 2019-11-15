using System;
using System.Collections.Generic;


namespace multifabriken
{
    public class Havremjölk // klassens namn
    {
        // Klassens fält
        private string fetthalt, litermängd;

        // klassens metod för beställning
        public void mjölkBeställning()
        {
            // skriver ut information till användaren 
            Console.WriteLine("För att beställa havremjölk");
            Console.WriteLine("Fetthalt:");
            fetthalt = Console.ReadLine(); // lagrar användarens svar
            Console.WriteLine("Litermändg:");
            litermängd = Console.ReadLine(); // lagrar användarens svar
        }
        // klassens metod för beställd produkt
        public void beställdMjölk()
        {
            // skriver ut information om beställd produkt till användaren
            Console.WriteLine("Beställd havremjölk");
            Console.WriteLine($"Fetthalt: {fetthalt}, Litermängd: {litermängd}");
        }
    }
}