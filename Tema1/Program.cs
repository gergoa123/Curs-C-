using System;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea");
            int lungime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti latimea");
            int latime = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduceti inaltimea");
            int inaltime = Convert.ToInt32(Console.ReadLine());

            int volum = lungime * latime * inaltime;

            Console.WriteLine("Volumul paralelipipedului greptunghic este " + volum);
        }
    }
}
