using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string ism = "";
            int yosh = 0;
            string[] ismlar = new string[]
            {
                "Abduvaliev Sherzod",
                "Bahriddinov Abdumajid",
                "Doniyorov G'anisher",
                "Nurbekov Bektemir",
                "Nusratov Oybek",
                "Mo'minova Amina",
                "Eshonqulova Parvina",
                "Qilichev Sardor",
                "Qahramovon Amon",
                "Teshaboyeb Temur"
            };

            do
            {
                Console.Clear();
                Console.WriteLine("Iltimos ism va yoshni kiriting");
                ism = Console.ReadLine();
                yosh = Convert.ToInt32(Console.ReadLine());

            } while (yosh < 6);

            while (yosh < 10)
            {
                Console.WriteLine($"{ism} bizda o'qiyapti.\n Yoshi {yosh}");
                yosh++;
            }
            Console.WriteLine("for dan foydalandik");
            for (int i = 0; i < ismlar.Length; i++)
            {
                Console.WriteLine($"{i + 1} {ismlar[i]}");
            }
            Console.WriteLine("foreach dan foydalandik");
            foreach (var birIsm in ismlar)
            {
                Console.WriteLine($"{birIsm}");
            }


            Console.ReadKey();
        }
    }
}
