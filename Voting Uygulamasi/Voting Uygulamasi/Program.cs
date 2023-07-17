namespace Voting_Uygulamasi
{
    public class Program
    {
        static void Main(string[] args)
        {
            Kategoriler kategoriler1 = new Kategoriler();
            
            do
            {
                Console.WriteLine("Kullanici id giriniz");
                string user = Console.ReadLine();
                
                KullaniciIslemleri kullaniciIslemleri = new KullaniciIslemleri();
                kullaniciIslemleri.KullaniciKontrolu(user);
                Kategoriler kategoriler = new Kategoriler();
                kategoriler.KategoriSecimi();
                
            } while (CikisIslemi());
            kategoriler1.OylamaSonucu();
           


        }
        public static bool CikisIslemi()
        {
            Console.WriteLine("Cikmak icin e ye basin devam icin herhangi bir tusa basin");
            char tercih = Convert.ToChar(Console.ReadLine());
            if (tercih == 'e')
            {
                return false;
            }
            else { return true; }

        }

    }
}