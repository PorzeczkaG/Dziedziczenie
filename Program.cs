using System;
using System.Threading.Tasks;

namespace Dziedziczenie{
    class CNazwisko
    {
        public void nazwisko()
        {
            Console.WriteLine("Nazwisko:    Kowalski");
        }

    }

    class CImie : CNazwisko
    {
        public void imie()
        {
            Console.WriteLine("Imie:    Jan");

        }
    }
    class osoba : CImie
    {

    }

class Program
    {
        static void Main(string[] args)
        {
            osoba p1 = new osoba();
            p1.imie();
            p1.nazwisko();


            Console.ReadKey();
        }
    }

    }

