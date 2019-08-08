using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0601A3Feldertausch
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte[] feld = new sbyte[10];
            sbyte x;
            Random zuf = new Random();

            for (int i = 0; i < 10; i++)
                feld[i] = (sbyte)(zuf.Next(1, 33));

            foreach (int n in feld)
                Console.Write($"{n} ");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                x = feld[i];
                feld[i] = feld[9 - i];
                feld[9 - i] = x;
            }
            foreach (int n in feld)
                Console.Write($"{n} ");
            Console.WriteLine();

        }
    }
}
