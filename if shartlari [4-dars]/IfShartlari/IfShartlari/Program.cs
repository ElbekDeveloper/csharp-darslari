using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Ro'yhatdan o'tish sistemasi

namespace IfShartlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //o'zgaruvchilarni e'lon qilamiz
            string ism;
            int yosh;


            //o'zgaruchilarni qabul qilamiz
            Console.WriteLine("Salom, iltimos quyidagi ma'lumotlarni kiriting!");
            Console.Write("Ism: ");
            ism = Console.ReadLine();
            Console.Write("Yosh: ");
            yosh = Convert.ToInt32(Console.ReadLine());

            //agar yoshi kichik bo'lsa 18 dan
            if(yosh < 18)
            {
                Console.WriteLine($"Kechirasiz {ism}, siz hali yoshsiz!");
            } else if (yosh >= 18 && yosh < 27)
            {
                Console.WriteLine($"Tabriklaymiz {ism}, siz harbiy xizmat o'tay olasiz!");
            }
            else
            {
                Console.WriteLine("Siz harbiy xizmatga bora olmaysiz!");
            }

            //switch bilan ishlash
            switch (ism)
            {
                case "Elbek":
                    Console.WriteLine("Siz dasturlashni o'rgatasiz!");
                    break;
                case "G'anisher":
                    Console.WriteLine("Siz dasturlashni o'rganasiz");
                    break;
                // yana "case" yozish mumkin
                default:
                    Console.WriteLine("Siz default holatga tushdingiz.");
                    break;
            }












        }
    }
}
