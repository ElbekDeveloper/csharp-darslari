using System;

namespace EJurnal
{
    class Program
    {
        static void Main(string[] args)
        {
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

            int[] baholar = new int[]
            {
                5,
                4,
                4,
                5,
                3,
                4,
                5,
                5,
                5,
                3
            };
            int[] random = new int[]
            {
                5,
                4,
                4,
                5,
                3,
                4,
                5,
                5,
                5,
                3
            };
            //Array.Sort(random);
            //Console.WriteLine(random[0]);

            //Console.WriteLine(ismlar.Length);
            //Console.WriteLine(baholar.Length);


            //Console.WriteLine($"1. {ismlar[0]} | {baholar[0]} |");
            //Console.WriteLine($"2. {ismlar[1]} | {baholar[1]} |");
            //Console.WriteLine($"3. {ismlar[2]} | {baholar[2]} |");
            //Console.WriteLine($"4. {ismlar[3]} | {baholar[3]} |");
            //Console.WriteLine($"5. {ismlar[4]} | {baholar[4]} |");
            //Console.WriteLine($"6. {ismlar[5]} | {baholar[5]} |");
            //Console.WriteLine($"7. {ismlar[6]} | {baholar[6]} |");
            //Console.WriteLine($"8. {ismlar[7]} | {baholar[7]} |");
            //Console.WriteLine($"9. {ismlar[8]} | {baholar[8]} |");
            //Console.WriteLine($"10. {ismlar[9]} | {baholar[9]} |");

            string ism = "";
            int yosh = 0;
            do
            {
                Console.WriteLine("Iltimos ma'lumotlarni kiriting");
              ism = Console.ReadLine();
              yosh = Convert.ToInt32(Console.ReadLine());
            } while (String.IsNullOrEmpty(ism) && yosh > 6);
            Console.WriteLine("Bu loop ni tashqarisida");

            while (yosh < 18)
            {
                Console.WriteLine($"{ism} maktabda o'qiyapti va yoshi {yosh}da");
                yosh++;
            }
            Console.WriteLine($"Demak {ism} 18 dan katta bo'lipti");


        }
    }
}
