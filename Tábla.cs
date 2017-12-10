using System;

namespace OkjKiralynok
{
    class Tábla // 1. feladat
    {
        char[,] T; // 2. feladat
        char ÜresCella; // 2. feladat

        public Tábla(char üresCella) // 3. feladat
        {
            T = new char[8, 8]; // 3.a
            ÜresCella = üresCella; // 3.b
            for (int i = 0; i < 8; i++) // 3.c
            {
                for (int j = 0; j < 8; j++)
                {
                    T[i, j] = ÜresCella; // 3.c
                }
            }
        }

        public void Megjelenít() // 4. feladat
        {
            for (int sor = 0; sor < 8; sor++)
            {
                for (int oszlop = 0; oszlop < 8; oszlop++)
                {
                    Console.Write("{0}", T[sor, oszlop]);
                }
                Console.WriteLine();
            }
        }
    }
}