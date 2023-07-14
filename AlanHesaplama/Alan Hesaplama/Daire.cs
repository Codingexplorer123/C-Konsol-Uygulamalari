using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class Daire:DaireIslemler
    {

        public override void AlanHesabi(double yaricap)
        {


            double daireninAlani = Math.PI * Math.Pow(yaricap, 2);
        }

        public override void CevreHesabi(double yaricap)
        {
            double daireninCevresi = Math.PI * 2 * yaricap;
        }

        public override void HacimHesabi(double yaricap,double yukseklik)
        {
            double daireninHacmi = Math.PI * Math.Pow(yaricap,2)*yukseklik;
        }
    }

}
