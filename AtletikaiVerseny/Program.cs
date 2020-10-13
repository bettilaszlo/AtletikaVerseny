using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atletika> tavol = new List<Atletika>();
        static void Beolvas()
        {
            StreamReader file = new StreamReader("tavol.csv");
            while (!file.EndOfStream)
            {
                tavol.Add(new Atletika(file.ReadLine()));
            }
            file.Close();
            Console.WriteLine("1. feladat: adatok beolvasása");

        }
        static void Masodikfeldat()
        {
            foreach (var t in tavol)
            {
                Console.WriteLine();
                
            }
            Console.WriteLine("\n2. feladat: Nevek és ugrások: {0} {1} {2}");

        }
        static void Harmadikfeldat()
        {
            Console.WriteLine("\n3. feladat: Egyesületek:");
        }
        static void Negyedikfeldat()
        {
            double max = 0;
            foreach (var m in tavol)
            {

            }
            Console.WriteLine("\n4. feladat: Legnagyobb ugrás:");
        }
        static void Otodikfeldat()
        {
            double atlag;
            foreach (var a in tavol)
            {
                if (atlag >)
                {

                }
            }
            Console.WriteLine("\n5. feladat: Átlag alatt lévő ugrások száma: {0}");
        }
        static void Hatodikfeldat()
        {
            StreamWriter ir = new StreamWriter("versenyzok.txt");
            foreach (var v in tavol)
            {

            }
            ir.Close();
            Console.WriteLine("\n6. feladat: Adatok fájlba írása:");
        }
        static void Main(string[] args)
        {
            Beolvas();
            Masodikfeldat();
            Harmadikfeldat();
            Negyedikfeldat();
            Otodikfeldat();
            Hatodikfeldat();

            Console.ReadKey();
        }
    }
}
