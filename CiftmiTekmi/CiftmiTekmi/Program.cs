using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiftmiTekmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Girilen Sayı Çift mi Tek mi 
            int sayi, sonuc;
            Console.WriteLine("Sayı Giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());
            sonuc = sayi % 2;
            if (sonuc == 0)
                Console.WriteLine("Sayı Çifttir");
            else
                Console.WriteLine("Sayı Tektir");
            Console.ReadKey();
        }
    }
}
