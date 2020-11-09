using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ToonPenen_Test9
{
    class Program
    {
        static void Main(string[] args)
        {
            double rl; 
            double total;
            double per;
            string dev;

            Console.Write("\n\n");
            Console.Write("Calculate the total, with discount of 5% if total is bigger tan 5000:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Geef het totaal van de factuur\n");
            rl = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Input the Name of the Student :");
            //nm = Console.ReadLine();

            //Console.Write("Input  the marks of Physics : ");
            //phy = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input  the marks of  Chemistry : ");
            //che = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Input  the marks of Computer Application : ");
            //ca = Convert.ToInt32(Console.ReadLine());

            per = rl / 20;
            total = rl - per;

            if (rl > 5000)
            total = rl - per;
            div= Console.WriteLine("totaal factuur is: ", total)
            if (rl<= 5000)
        
            Console.WriteLine("totaal factuur is: ", rl);

            
            //else
            //    if (per < 48 && per >= 36)
            //    div = "Pass";
            //else
            //    div = "Fail";

            //Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
            //Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
            //Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
        }
    }
}
