using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lees een bedrag in van een factuur.
            //Indien het bedrag groter is dan 5000 euro, dan wordt er een korting van 5 % toegestaan.
            //Toon het uiteindelijke resultaat.

            #region Algemene Info
                Console.Write("\n\n");
                Console.Write("Bereken het te betalen bedrag ven de factuur, met een korting van 5% als het factuurbedrag groter is dan 5000 $:\n");
            //Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");
            #endregion

            #region Inputgegevens
            Console.WriteLine("Geef het totaal van de factuur:");
                double factuur = Convert.ToInt32(Console.ReadLine());
                double discount = 5;
                double  afterDiscount = factuur - (factuur * discount / 100);
            #endregion
            #region Output gegevens
            if (afterDiscount > 5000)
                Console.WriteLine("Na de korting is het te betalen bedrag: " + afterDiscount + " $");
            else 
                Console.WriteLine(("Dit is het te betalen bedrag: " + factuur + " $"));
            #endregion
        }
    }
}
