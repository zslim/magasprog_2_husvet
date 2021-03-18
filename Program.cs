using System;
using System.Collections.Generic;
using System.Linq;

namespace Husvet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöljük a Három Seprűben!");
            Kocsma haromSepru = new Kocsma();
            haromSepru.FillFromFile("input.txt");

            List<Locsolkodo> ibolya = haromSepru.PeopleWithKolni(Kolni.Ibolya);
            List<Locsolkodo> ibolyaReszeg = ibolya.Where(person => person.IsTotallyWasted).ToList();

            System.Console.WriteLine("Ibolyaillatú kölnivel rendelkező, vállalhatatlanul részeg vendégeink:");
            foreach (var person in ibolyaReszeg)
            {
                System.Console.WriteLine(person);
            }
        }
    }
}
