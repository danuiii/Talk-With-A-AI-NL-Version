using System;
using System.IO;

namespace Praat_Met_De_Ai
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kleur van de text aan passen.

            Console.ForegroundColor = ConsoleColor.Green;

            // Praat met de AI.

            Console.WriteLine("Bliep Bloep Blap");

            Console.WriteLine("Hallo, Ik ben een AI. En jou naam is?");

            var name = Console.ReadLine();

            Console.WriteLine($"Hey {name}. Wat is je favoriete kleur?");

            var color = Console.ReadLine();

            Console.WriteLine($"{color} dat noem ik nou eens een mooie kleur {name}. Mijn favoriete kleur is ConsoleColor.Green;");

            Console.WriteLine("Ik zou je is een verhaaltje vertellen over een ridder, EN JIJ MAG MEE HELPEN :)");

            Console.WriteLine("Een coole ridder genaamd . . .");

            Console.ReadLine();

            Console.WriteLine("En zijn hulpje . . .");

            Console.ReadLine();

            Console.WriteLine("Werden op een dag opgegeten door een draak genaamd . . .");

            Console.ReadLine();

            Console.Write("EINDE!!! Wat vond je ervan?");

            Console.ReadLine();

            Console.WriteLine($"Dankje, dankje. Nou ik moet maar eens gaan {name}. Doei doei!!!");

            Console.WriteLine("Klik 2 keer op spatie om weg te gaan.");

            Console.ReadKey();

        }
    }
}
