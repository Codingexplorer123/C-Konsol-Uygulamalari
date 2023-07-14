using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class Dikdortgen: IDikdortgen
    {
        public void AlanHesabi(double kenar1, double kenar2)
        {
            Console.WriteLine($"Dikdortgenin Alani: {kenar1*kenar2}");
        }

        public void CevreHesabi(double kenar1, double kenar2)
        {
            Console.WriteLine($"Dikdortgenin Cevresi: {2*(kenar1+kenar2)}");
        }
        public void HacimHesabi(double kenar1, double kenar2, double yukseklik)
        {
            Console.WriteLine($"Dikdortgenin Hacmi: {kenar1*kenar2*yukseklik}");
        }
    }
}
