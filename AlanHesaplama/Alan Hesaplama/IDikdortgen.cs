using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    internal interface IDikdortgen
    {
        public void AlanHesabi(double kenar1, double kenar2);
        public void CevreHesabi(double kenar1, double kenar2);

        public void HacimHesabi(double kenar1, double kenar2, double yukseklik);
    }
}
