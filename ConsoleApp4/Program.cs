using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Razlomak r1 = new Razlomak(5, 20);
            Razlomak r2 = new Razlomak(1, 9);
            Razlomak r3 = new Razlomak(22, 20);
            List<Razlomak> raz = new List<Razlomak>();
            raz.Add(r1);
            raz.Add(r2);
            raz.Add(r3);
            foreach(Razlomak r in raz)
            {
                Console.WriteLine("Razlomak : {0}/{1}, njegova decimalna vrijednost: {2}" , r.Brojnik, r.Nazivnik,r.PretvoriUFloat());  
            }

            raz.Sort();

            Console.WriteLine("Poslije sortiranja: ");

            foreach (Razlomak r in raz)
            {
                Console.WriteLine("Razlomak : {0}/{1}, njegova decimalna vrijednost: {2}", r.Brojnik, r.Nazivnik, r.PretvoriUFloat());
            }
            
        }
    }
}
