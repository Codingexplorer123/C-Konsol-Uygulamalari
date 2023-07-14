using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public abstract class DaireIslemler
    {
        public abstract void CevreHesabi(double degisken);
        public abstract void AlanHesabi(double degisken);

        public abstract void HacimHesabi(double degisken,double yukseklik);
        
    }
}
