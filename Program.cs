using System;
using System.Collections.Generic;



namespace multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------- Klasser-------------------------------*/
            // Hämtar Klasserna
            Bil bil = new Bil();
            Godis godis = new Godis();
            Havremjölk mjölk = new Havremjölk();
            Rör rör = new Rör();
            /*-------------Klasser-------------------------------*/

            /*------------- Listor-------------------------------*/
            //skapar listor för produkterna
            List<Bil> ListBilar = new List<Bil>();
            List<Godis> ListGodis = new List<Godis>();
            List<Rör> ListRör = new List<Rör>();
            List<Havremjölk> ListMjölk = new List<Havremjölk>();
            /*------------- Listor-------------------------------*/

            bool kör = true; // Loopar koden
            // skapar variabel för anvädarens val
            string val = "";

            // Loopar menyn
            while (kör)
            {
                Console.WriteLine("Välkommen till Multifabriken! Tryck:");
                Console.WriteLine("");
                Console.WriteLine("[1] om du vill beställa: Bil");
                Console.WriteLine("[2] om du vill beställa: Godis");
                Console.WriteLine("[3] om du vill beställa: Rör");
                Console.WriteLine("[4] om du vill beställa: Havremjölk");
                Console.WriteLine("[5] för att se beställda produkter");
                Console.WriteLine("[6] för att avsluta...");
                // Hämtar användarens val
                val = Console.ReadLine();

                // Switch med olika caser som användaren man välja bland
                switch (val)
                {
                    case "1":
                        bil.bilBeställning(); // Hämtar koden för beställning från klassen
                        ListBilar.Add(bil);   // lagrar den beställda produkten på listan för bil
                        foreach (var item in ListBilar)
                        {
                            bil.beställdBil();
                        }
                        break;

                    case "2":
                        godis.Godisbeställning();   // Hämtar koden för beställning från klassen
                        ListGodis.Add(godis);       // lagrar den beställda produkten på listan för godis
                        foreach (var item in ListGodis)
                        {
                            godis.beställdGodis();
                        }
                        break;

                    case "3":
                        rör.rörBeställning();   // Hämtar koden för beställning från klassen
                        ListRör.Add(rör);   // lagrar den beställda produkten på listan för rör
                        foreach (var item in ListRör)
                        {
                            rör.beställdRör();
                        }
                        break;

                    case "4":
                        mjölk.mjölkBeställning();   // Hämtar koden för beställning från klassen
                        ListMjölk.Add(mjölk);   // lagrar den beställda produkten på listan för havremjölk
                        foreach (var item in ListMjölk)
                        {
                            mjölk.beställdMjölk();
                        }
                        break;

                    case "5": // Visar vilka produkter användaren har beställt 
                        Console.WriteLine("Du beställde följande produkter");
                        bil.beställdBil();
                        godis.beställdGodis();
                        rör.beställdRör();
                        mjölk.beställdMjölk();
                        break;

                    case "6": // Avslutar programmet 
                        kör = false;
                        break;

                    default: // Skriver ut meddelande vid felaktigt val
                        Console.WriteLine("ogilgt val");
                        break;

                }
            }

        }
    }
}
