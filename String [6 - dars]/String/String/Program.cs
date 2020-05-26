using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
           // string ism;
           //string familiya;
            string matn = "Gulla, Yashna, Vatanim!";
            int sozPozitsiyasi = matn.IndexOf("Vatanim");
            int matnUzunligi = matn.Length;
            int kesmaUzunligi = 2;
            string kesilganMatn = matn.Substring(sozPozitsiyasi);
            string kesikMatnIkki = matn.Substring(sozPozitsiyasi, kesmaUzunligi);
            

            Console.WriteLine(kesilganMatn);
            Console.WriteLine(kesikMatnIkki);


            /*
            Console.WriteLine("Xush kelibsiz!\nIltimos, ismingizni kiriting!");
            ism = Console.ReadLine();
            Console.WriteLine("Iltimos, familiyangizni kiriting!");
            familiya = Console.ReadLine();

            //ekranga chiqaramiz
            Console.WriteLine("Sizning ismingiz " + ism + " va familiyangiz " + familiya); //concatination

            Console.WriteLine($"Sizning ismingiz {ism} va familiyangiz {familiya}");        // interpolation

            //metod 
            Console.WriteLine(ism.ToUpper());
            Console.WriteLine(ism.ToLower());
            */
        }
    }
}
