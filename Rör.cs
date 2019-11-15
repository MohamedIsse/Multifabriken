using System;
using System.Collections.Generic;


namespace multifabriken
{
    class Rör // klassens namn
    {
        // Klassens fält
        public string diameter, längd;

        // klassens metod för beställning
        public void rörBeställning()
        {
            // skriver ut information till användaren 
            Console.WriteLine("För att beställa rör behöver du ange");
            Console.WriteLine("Diameter:");
            diameter = Console.ReadLine(); // lagrar användarens svar
            Console.WriteLine("Längd:");
            längd = Console.ReadLine(); // lagrar användarens svar
        }
        // klassens metod för beställd produkt
        public void beställdRör()
        {
            // skriver ut information om beställd produkt till användaren
            Console.WriteLine("Beställd rör");
            Console.WriteLine($"Diameter: {diameter}, Längd: {längd}");
        }
    }
}