using System;
using System.Text.RegularExpressions;

namespace ParolKuchlimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //mezonlar
            const int parolUzunligi = 8;
            var raqamlarRx = new Regex(@"[0-9]");
            var kattaHarflarRx = new Regex(@"[A-Z]");
            var kichikHarflarRx = new Regex(@"[a-z]");
            var belgilarRx = new Regex(@"[!-/]");
            //baho
            int baho = 0;

            //parol kiritilishi
            //ekranga yozuv chiqarish
            Console.Write("Parolingizni kiriting: ");
            string parol = Console.ReadLine();

            //tekshirish
           /* if(parol.Length >= parolUzunligi)
            {
                baho++;
            }*/
            //ternary
            baho += (parol.Length >= parolUzunligi) ? 1 : 0;
            var raqamlargaTekshirish = raqamlarRx.Match(parol);
            baho += (raqamlargaTekshirish.Success) ? 1 : 0;
            var kattagaTekshirish = kattaHarflarRx.Match(parol);
            baho += kattagaTekshirish.Success ? 1 : 0;
            var kichikgaTekshirish = kichikHarflarRx.Match(parol);
            baho += kichikgaTekshirish.Success ? 1 : 0;
            var belgilargaTekshirish = belgilarRx.Match(parol);
            baho += belgilargaTekshirish.Success ? 1 : 0;


            switch (baho)
            {
                case 1:
                case 2:
                    Console.WriteLine("Kuchsiz parol");
                    break;
                case 3:
                    Console.WriteLine("Yaxshi parol");
                    break;
                case 4:
                    Console.WriteLine("Kuchli parol");
                    break;
                case 5:
                    Console.WriteLine("O'ta kuchli parol");
                    break;
                default:
                    break;
            }
        }
    }
}
