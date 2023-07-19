using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class KullaniciKimlikDogrulama
    {
        // Aslinda kullanici adi ve sifreleri databasede tutmak daha mantikli fakat burda sadece konsol uygulama oldugu icin sadece uc kisinin
        //kullanici adi ve sifresini liste olarak bu uygulamada tutacagim.
        Dictionary<string, int> dogrulama = new Dictionary<string, int>() { { "Emir Alp", 1234 }, { "Esra Yildirim", 2468 }, { "Emre Ozdemir", 1357 } };


        public bool KimlikDogrulama()
        {
            int denemeHakki = 3;
            do
            {
                Console.WriteLine("Kullanici Adini Giriniz:");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Kullanici Sifresini Giriniz: ");
                try
                {
                    int kullaniciSifre = Convert.ToInt16(Console.ReadLine());
                    int sifrekontrolu;
                    if (dogrulama.ContainsKey(kullaniciAdi) && dogrulama.TryGetValue(kullaniciAdi, out sifrekontrolu) && sifrekontrolu == kullaniciSifre)
                    // trygetvalue metodu sozluk yapisi icerisinde kullaniciadi degisken degerinde anahtar var ise, karsisindaki degeri sifrekontrolu adindaki
                    //degiskene gondererek true doner, daha sonrasinda bu deger ile konsoldan girilen degerle aynimi diye kontrol yapiyoruz.
                    {
                        Console.WriteLine("Kullanici dogrulandi");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("kullanici adiniz veya sifreniz hatalidir. Lutfen tekrardan giriniz.");
                        denemeHakki--;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Sifresiniz pozift rakamlardan olusmalidir.");
                    denemeHakki--;
                }
               
            } while (denemeHakki >0);
            Console.WriteLine("4 kere hatali girdiginizden hesabiniz bloke edilmistir");
            return false;

        }
    }
}
