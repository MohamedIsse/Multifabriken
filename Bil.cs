using System;
using System.Collections.Generic;


namespace multifabriken
{
    public class Bil // klassens namn
    {
        // Klassens fält
        public string regnr, färg, märke;

        // klassens metod för beställning
        public void bilBeställning()
        {
            // skriver ut information till användaren 
            Console.WriteLine("För att beställa en bil behöver du ange");
            Console.WriteLine("Regnrummer:");
            regnr = Console.ReadLine().ToUpper(); // lagrar användarens svar i versaler
            Console.WriteLine("Märke:"); 
            märke = Console.ReadLine(); // lagrar användarens svar
            Console.WriteLine("färg:");
            färg = Console.ReadLine(); // lagrar användarens svar
        }
        // klassens metod för beställd produkt
        public void beställdBil()
        {
            // skriver ut information om beställd produkt till användaren
            Console.WriteLine("Beställd bil");
            Console.WriteLine($"Märke: {märke},Färg: {färg}, Regnummer: {regnr}");
            
        }
    }
}