using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArrayOef2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tom Adriaens     
            // 09/01/2024
            // Oef2: Array

            // Velden 
            
            String[] _voornamen = new string[0];
            int _aantal = 0;

            byte _keuze = 0;

            // Programma
            do
            {
                // Scherm leegmaken 
                Console.Clear();

                //Stap 1:  Toon menu(ingeven aantal Leerlingen, namen ingeven, toon namen, afsluiten)
                Console.WriteLine("Maak uw keuze uit onderstaand menu:");
                Console.WriteLine("\n   1) Ingeven aantal leerlingen \n   2) Alle namen ingeven \n   3) Toon allen namen \n   4) Afsluiten");
                Console.Write("\n\n: uw keuze: ");


                try
                {
                    // Keuze opslaan
                    _keuze = byte.Parse(Console.ReadLine());

                    // Scherm wissen
                    Console.Clear();

                    // Als 1: Vraag het aantal leerlingen + sla op 
                    if (_keuze == 1)
                    {
                        Console.Write($"Hoeveel leerlingen telt je klas : ");
                        _aantal = int.Parse(Console.ReadLine());

                        _voornamen = new string[_aantal];

                        // Scherm wissen
                        Console.Clear();

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDe klas werd aangemaakt.");
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 2: Vraag alle namen + sla op 
                    else if (_keuze == 2)
                    {
                        // Vraag de namen 
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            Console.Write($"Geef leerling {(i+1).ToString()} in : ");
                            _voornamen[i] = Console.ReadLine();
                        }

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    //Als 3: Toon de namen op het scherm.
                    else if (_keuze == 3)
                    {
                        // array overlopen en op het scherm tonen
                        for (int i = 0; i < _voornamen.Count(); i++)
                        {
                            Console.WriteLine(_voornamen[i]);
                        }

                        // Gebruiker begeleiden
                        Console.WriteLine("\n\nDruk op enter om verder te gaan.");
                        Console.ReadKey();
                    }

                    // Als 4: Sluit af.
                    else if (_keuze == 4)
                    {
                        // afsluiten
                        Console.WriteLine("Dag en tot een volgende keer.");
                        Console.WriteLine("Druk op enter om af te sluiten.");
                        Console.ReadKey();
                    }
                    else
                    {

                        // foutmelding
                        Console.WriteLine("U gaf geen juiste keuze in.");
                        Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                        Console.ReadKey();
                    }

                }
                catch
                {
                    // Scherm leegmaken 
                    Console.Clear();

                    // foutmelding
                    Console.WriteLine("U gaf geen getal in.");
                    Console.WriteLine("Druk op enter om terug te keren naar het hoofdmenu.");
                    Console.ReadKey();

                }

            } while (_keuze != 4);

        }
    }
}
