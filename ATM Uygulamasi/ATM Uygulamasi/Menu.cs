using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class Menu
    {
        public void AnaMenuGoster()
        {
            Console.WriteLine("ATM Uygulamasına Hoş Geldiniz!");
            Console.WriteLine("1. Bakiye Sorgulama");
            Console.WriteLine("2. Para Çekme");
            Console.WriteLine("3. Para Yatırma");
            Console.WriteLine("4. Çıkış");
            Console.WriteLine("5. LogKayit");
            Console.Write("Seçiminizi yapın (1-5): ");
        }
        public bool AnaMenuKontrol(byte secim)
        {
            
            if (!byte.TryParse(Console.ReadLine(), out secim) || secim < 1 || secim > 4)
            //Eger consoldan alinan deger byte donusturulemiyosa ve secinlen deger 1 den kucuk yada deger 4 ten buyukse
            {
                Console.WriteLine("Isleminiz kontrol ediliyor.");
                return true;
            }
            else
            {
                Console.WriteLine("Talebiniz alinmistir.");
                return false;
            }
         // Buradaki method ile girilen deger gecerli bir deger olana kadar menu gosterilmeye devam edip donguye sokuluyor. Kullanici
         // donguden ancak dogru bir deger girince cikabiliyor.
        }
    }
}
