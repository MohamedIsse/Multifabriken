using System;
using System.Collections.Generic;


namespace multifabriken
{
    public class Godis // klassens namn
    {
        // Klassens fält
        private string smak;
        private int antal;

        // klassens metod för beställning
        public void Godisbeställning()
        {
            // skriver ut information till användaren 
            Console.WriteLine("För att beställa godis behöver du ange: ");
            Console.WriteLine("Smak:");
            smak = Console.ReadLine(); // lagrar användarens svar 
            Console.WriteLine("Antal:");
            antal = int.Parse(Console.ReadLine()); // lagrar användarens svar
        }

        // klassens metod för beställd produkt
        public void beställdGodis()
        {
            // skriver ut information om beställd produkt till användaren
            Console.WriteLine("Beställd godis");
            Console.WriteLine($"Smak: {smak}, Antal: {antal}");
            
        }
    }
}