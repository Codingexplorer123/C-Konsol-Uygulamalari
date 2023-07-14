using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class Ucgen : IUcgenIslemler
    {
        public void UcgenAlanBulma(double tabankenar, double yukseklik)
        {
            Console.WriteLine($"{tabankenar}*{yukseklik / 2}: Ucgenin Alani");
        }

        public void UcgenCevreBulma(double degisken1, double degisken2, double degisken3)
        {
            Console.WriteLine($"Ucgenin Cevresi: {degisken1+degisken2+degisken3}");
        }
    }
}
