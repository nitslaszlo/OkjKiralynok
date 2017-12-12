using System;

namespace OkjKiralynok
{
    class Kiralynok // 0. feladat (Fájl neve Kiralynok.cs)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("4. feladat: Az üres tábla:");
            Tábla tábla = new Tábla('#');
            tábla.Megjelenít();

            Console.ReadKey();
        }
    }
}