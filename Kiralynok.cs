using System;
using System.IO; // 10. feladat

namespace OkjKiralynok
{
    class Kiralynok // 0. feladat (Fájl neve Kiralynok.cs)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. feladat: Az üres tábla:");
            Tábla t = new Tábla('#');
            t.Megjelenít();

            Console.WriteLine("\n6. feladat: A feltöltött tábla:");
            t.Elhelyez(8);
            t.Megjelenít();

            Console.WriteLine("\n9. feladat: Üres oszlopok és sorok száma:");
            Console.WriteLine($"Oszlopok: {t.ÜresOszlopokSzáma}");
            Console.WriteLine($"Sorok: {t.ÜresSorokSzáma}");

            // 10. feladat
            const string fn = "tablak64.txt";
            if (File.Exists(fn)) File.Delete(fn);  // System.IO névtér importja
            Console.WriteLine($"10. feladat: {fn}");
            for (int i = 1; i < 65; i++)
            {
                Tábla tbl = new Tábla('*');
                tbl.Elhelyez(i);
                tbl.FájlbaÍr(fn);
            }

            Console.ReadKey();
        }
    }
}
