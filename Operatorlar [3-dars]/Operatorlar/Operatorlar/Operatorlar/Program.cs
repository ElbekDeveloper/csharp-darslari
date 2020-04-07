using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            double c = 21.12;
            double d = 11.44;
            bool rost = true;
            bool yolgon = false;



                       //Arifmetik Operatorlar
                        Console.WriteLine("Arifmetik Operatorlar");
                        Console.WriteLine(a + b); // qo'shish
                        Console.WriteLine(a - b); // ayirish
                        Console.WriteLine(a * b); // ko'parytirish
                        Console.WriteLine(a / b); //bo'lish
                        Console.WriteLine(b % a); // qoldiq
                        Console.WriteLine(a++); // postfix
                        Console.WriteLine(++a); // prefix
                        Console.WriteLine(a--); // postfix
                        Console.WriteLine(--a); // prefix

                        // Qiyoslash Operatorlari
                        // true yoki false qiymat qaytaradi
                        Console.WriteLine("Qiyoslash operatorlari");
                        Console.WriteLine(c == d);
                        Console.WriteLine( c != d);
                        Console.WriteLine( c > d);
                        Console.WriteLine( c < d);

                        //Mantiqiy operatorlar
                        // true yoki false qiymat qaytaradi
                        Console.WriteLine("Mantiqiy Operaotorlar");
                        Console.WriteLine(rost && yolgon);
                        Console.WriteLine(rost || yolgon);
                        Console.WriteLine(!(rost && yolgon));

            // Tayinlash operatorlari
            Console.WriteLine("Tayinlash Operatorlari");
            Console.WriteLine(a);
            Console.WriteLine(a = b);
            Console.WriteLine(a == b);
            Console.WriteLine(a += b);
            Console.WriteLine(a -= 2);
            Console.WriteLine(a /= 2);
            Console.WriteLine(a *= 5);














        }
    }
}
