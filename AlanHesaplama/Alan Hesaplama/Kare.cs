using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alan_Hesaplama
{
    public class Kare:IKare
    {
        public void AlanBulma(double kenar1)
        {
            Console.WriteLine($"Karenin Alani:{kenar1 * kenar1}");
        }

        public void CevreBulma(double kenar1)
        {
            Console.WriteLine($"Karenin Cevresi:{kenar1 * 4}");
        }

        public void HacimBulma(double kenar1)
        {
            Console.WriteLine($"Karenin Hacmi {Math.Pow(kenar1, 3)}");
        }

        
    }
}
