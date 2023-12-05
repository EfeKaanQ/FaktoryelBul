using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktoryelBul
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fakbul s=new Fakbul();
            Console.WriteLine("FAK BULUNACAK SAYIYI GİRİNİZ = ");
            int sayi = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sonuç=" + s.fak(sayi));
        }

    }
    class Fakbul
    {
        public int fak(int sayi)
        {
            int hesapla = 1;
            for (int i = 1; i <= sayi; i++)
            {
                hesapla = hesapla * i;
            }
            return hesapla;
        }
        
       
    }
}
