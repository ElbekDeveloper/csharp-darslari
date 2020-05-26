using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar_Bir
{
    class Program
    {
        static void Main(string[] args)
        {
            Salomlash();
            EkipajMalumoti();
            EkipajMalumoti(ayollarSoni: 3, erkaklarSoni: 4, kapitanNomi: "Steeve", azolarSoni: 7);
            Xayrlashuv();
        }
        static void EkipajMalumoti()
        {
            Console.WriteLine("bu overload qilingan metod");
            Console.WriteLine("1 kishi uchasiz");
        }
        static void EkipajMalumoti(int azolarSoni,
            int ayollarSoni,
            int erkaklarSoni,
            string kapitanNomi = "O'zingiz")
        {
            Console.WriteLine($"Siz {azolarSoni} kishi uchasiz!");
            Console.WriteLine($"Kema kapitani {kapitanNomi}");
            Console.WriteLine($"Ayollar Soni: {ayollarSoni}");
            Console.WriteLine($"Erkaklar Soni: {erkaklarSoni}");
        }
        static void Salomlash()
        {
            Console.WriteLine("Salom!\nKemamizga Xush Kelibsiz!");
        }
        static void Xayrlashuv()
        {
            Console.WriteLine("Safaringiz bexatar bo'lsin!");
        }
    }
}
