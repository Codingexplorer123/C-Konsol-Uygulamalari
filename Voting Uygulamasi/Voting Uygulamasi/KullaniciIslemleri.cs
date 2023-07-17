using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Uygulamasi
{
    public class KullaniciIslemleri
    {
        // Soruda sadece sisteme kayitli kullanicilar oy verebileceginden dolayi sistemde id no ile eslesen kullanici isimleri tanimladik.
        Dictionary<string, string> kullanici = new Dictionary<string, string>() { { "1", "Ali Yilmaz" }, { "2", "Ayse Ediz" }, { "3", "Hakan Calhanoglu" }, { "4", "Enes Turk" } };
        public void KullaniciKontrolu(string user)
        {
            // konsoldan alinan kullanicinin ismi bizim kayidimizda var mi diye kontrol ediyoruz.
            if (!kullanici.ContainsKey(user))
            // Eger yukaridaki id numarasinda kullanici yok ise ekleyecegiz yoksa ayni id numarasinda baska bir deger sozluk yapisina
            //eklenemez program run time de hata verir.
            {
                Console.WriteLine("Kullanicinin ismini giriniz");
                string isim = Console.ReadLine();
                kullanici.Add(user, isim);
            }
            else
            {
                Console.WriteLine("Bu kullanici zaten var");
            }
        }
    }
}
