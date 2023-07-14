using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Alan_Hesaplama
{
    internal class Program
    {
        enum Sekiller
        {
            Daire = 1,
            Ucgen,
            Kare,
            Dikdortgen
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Islem Yapilmak istenen geometrik sekili belirtiniz. Daire icin 1 Ucgen icin 2 Kare icin 3, dikdortgen icin 4 yaziniz");
            byte secim = Convert.ToByte(Console.ReadLine());
            // We will use explicit type casting to convert enum values

            if (secim == (int)Sekiller.Daire)
            {
                Daire daire = new Daire();
                Console.WriteLine("Dairenin Yaricapini giriniz");
                double yaricap = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hangi islemi yapmak istersiniz 1-AlanHesabi\t2-CevreHesabi\t3-HacimHesabi");
                char islem = Convert.ToChar(Console.ReadLine());
                if (islem == 1)
                {
                    daire.AlanHesabi(yaricap);
                }
                else if (islem == 2)
                {
                    daire.CevreHesabi(yaricap);
                }
                else if (islem == 3)
                {
                    Console.WriteLine("Dairenin yuksekligini giriniz");
                    double yukseklik = Convert.ToDouble(Console.ReadLine());
                    daire.HacimHesabi(yaricap, yukseklik);
                }
            }
            else if (secim == (int)Sekiller.Ucgen)
            {
                Ucgen ucgen = new Ucgen();
                Console.WriteLine("Ucgenin taban Kenarinin uzunlugunu giriniz");
                double tabankenar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ucgenin diger kenarinin uzunlugunu giriniz");
                double kenar1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ucgenin son kenarinin uzunlugunu girnizi");
                double kenar2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ucgenin yuksekligini giriniz");
                double yukseklik = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hangi islemi yapmak istersiniz 1-AlanHesabi\t2-CevreHesabi");
                char islem = Convert.ToChar(Console.ReadLine());
                if (islem == 1)
                {
                    Ucgen ucgen1 = new Ucgen();
                    ucgen.UcgenAlanBulma(tabankenar, yukseklik);
                }
                else if (islem == 2)
                {
                    Ucgen ucgen2 = new Ucgen();
                    ucgen2.UcgenCevreBulma(kenar1, kenar2, tabankenar);
                }
            }
            else if (secim == (int)Sekiller.Kare)
            {
                Kare kare = new Kare();
                Console.WriteLine("Karenin bir kenar uzunlugunu giriniz");
                double kenar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Hangi islemi yapmak istersiniz 1-AlanHesabi\t2-CevreHesabi\t3-HacimHesabi");
                char islem = Convert.ToChar(Console.ReadLine());
                if (islem == 1)
                {
                    kare.AlanBulma(kenar);
                }
                else if (islem == 2)
                {
                    kare.CevreBulma(kenar);
                }
                else if (islem == 3)
                {
                    kare.HacimBulma(kenar);

                }
                else if (secim == (int)Sekiller.Dikdortgen)
                {
                    Dikdortgen dikdortgen = new Dikdortgen();
                    Console.WriteLine("Dikdortgenin birinci kenarini giriniz");
                    double kenar1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dikdortgenin ikinci kenarini giriniz");
                    double kenar2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dikdortgenin yuksekligini giriniz");
                    double yukseklik = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Hangi islemi yapmak istersiniz 1-AlanHesabi\t2-CevreHesabi\t3-HacimHesabi");
                    char Islem= Convert.ToChar(Console.ReadLine());
                    if (Islem == 1)
                    {
                        dikdortgen.AlanHesabi(kenar1,kenar2);
                    }
                    else if (Islem == 2)
                    {
                        dikdortgen.CevreHesabi(kenar1,kenar2);
                    }
                    else if (islem == 3)
                    {
                        dikdortgen.HacimHesabi(kenar1, kenar2, yukseklik);

                    }

                }

            }

        }
    }
}