using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar_return
{
    class Program
    {
        static double AylanaYuzasiniHisoble(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        static double tortburchakYuziHisobla(double tomonBir, double tomonIkki)
        {
            return tomonBir * tomonIkki;
        }

        static void EkrangaChiqarish(double umumiyYuza)
        {
            Console.WriteLine($"Bino umumiy yuzasi {umumiyYuza}");
        }

        static void MalumotQabulQil(out double aylanaRadiusi, out double tortburchakIkkinchiTomoni, out double tortburchakTomoniBirinchi)
        {
            Console.WriteLine("Aylana radiusini kiriting");
            aylanaRadiusi = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("To'rburchak tomonlarini kiriting");
            tortburchakIkkinchiTomoni = Convert.ToDouble(Console.ReadLine());
            tortburchakTomoniBirinchi = Convert.ToDouble(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            //  1. parametrlarni e'lon qilish
            double aylanaRadiusi;
            double tortburchakTomoniBirinchi;
            double tortburchakIkkinchiTomoni;
            double aylanaYuzasi;
            double tortburchakYuzasi;
            double umumiyYuza;


            //  2. ularni qabul qilish

            MalumotQabulQil(out aylanaRadiusi, out tortburchakTomoniBirinchi, out tortburchakIkkinchiTomoni);

            //  3. aylana yuzani hisoblash

            // pi * radius * radius
            aylanaYuzasi = AylanaYuzasiniHisoble(aylanaRadiusi);

            //  4. to'rtburchak yuzasini hisoblash
            tortburchakYuzasi = tortburchakYuziHisobla(tortburchakTomoniBirinchi, tortburchakIkkinchiTomoni);

            //  5. yuzalarni qo'shish
            umumiyYuza = Math.Round(tortburchakYuzasi + aylanaYuzasi);
            //  6. ekranga chiqarish
            EkrangaChiqarish(umumiyYuza);   
        }
    }
}
