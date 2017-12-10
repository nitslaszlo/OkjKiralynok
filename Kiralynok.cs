using System;

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

            Console.ReadKey();
        }
    }
}
