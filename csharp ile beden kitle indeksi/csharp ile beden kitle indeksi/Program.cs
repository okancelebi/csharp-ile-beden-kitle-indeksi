using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ile_beden_kitle_indeksi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beden kitle indeksi = Kilo/Boy*Boy
            //Beden kitle indeksi 18'e eşit veya küçükse zayıf
            //18-25 arasında ise normal
            //25'ten büyük ise obez yazdıran programı kodlayınız.

            Console.WriteLine("Lütfen kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Lütfen boyunuzu giriniz.");
            double boy = Convert.ToDouble(Console.ReadLine());
            double bke = kilo / (boy * boy);
            if (bke < 18)
            {
                Console.WriteLine("Zayıfsınız...");
                Console.ReadLine();
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("Normalsiniz...");
                Console.ReadLine();
            }
            else if(bke > 25)
            {
                Console.WriteLine("Obezsiniz...");
                Console.ReadLine();
            }
        }
    }
}
