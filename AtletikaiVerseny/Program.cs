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
        static Dictionary<string, string> nevek = new Dictionary<string, string>();
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
            foreach (var e in tavol)
            {
                
            }
            Console.WriteLine("\n3. feladat: Egyesületek:");
        }
        static void Negyedikfeldat()
        {
            int max = 0;
            foreach (var m in tavol)
            {
                if (m.Ugras > max)
                {
                    max = m.Ugras;
                    Console.WriteLine("\n4. feladat: Legnagyobb ugrás: \n {0}cm", max);
                }  
            }
        }
        static void Otodikfeldat()
        {
            double atlag;
            double szum = 0;

            foreach (var t in tavol)
            {
                szum += t.Ugras;
           }
            atlag = szum / tavol.Count;
            if (atlag < szum)
            {
                Console.WriteLine("\n5. feladat: Átlag alatt lévő ugrások száma: {0}", tavol.Count);
            }
            
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
