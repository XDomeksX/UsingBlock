using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UsingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            using (Klasa objekt = new Klasa())
            {
                naredbe koje se izrvršavaju unutr bloka
                Na kraju bloka se poziva naredba objek.Dispose()
            }*/

            Console.WriteLine("Unesi ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Unesi prezime: ");
            string prezime = Console.ReadLine();

            Console.WriteLine("\n -------- Upisivanje podataka u datoteku...\n");

            using (StreamWriter sw = new StreamWriter(@"D:\Visual Studio\C#\UsingBlock\UsingBlock\mojaDatoteka.txt"))
            {
                sw.WriteLine("Ime: {0}", ime);
                sw.WriteLine("Prezime: {0}", prezime);
            }


            //čitanje podataka iz datoteke...
            Console.WriteLine("\n -------- Čitanje podataka iz datoteke...\n");

            using (StreamReader sr = new StreamReader(@"D:\Visual Studio\C#\UsingBlock\UsingBlock\mojaDatoteka.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }


            Console.ReadKey();
        }
    }
}
