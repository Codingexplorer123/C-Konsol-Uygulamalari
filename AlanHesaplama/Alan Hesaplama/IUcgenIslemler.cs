using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    internal interface IUcgenIslemler
    {
        public void UcgenCevreBulma(double degisken1, double degisken2, double degisken3);

        public void UcgenAlanBulma(double tabankenar, double yukseklik);

        
    }
}
