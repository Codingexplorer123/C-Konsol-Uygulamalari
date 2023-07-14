using System.Diagnostics;

namespace Integer_ikililerin_toplami
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekrandan girilecek sayilarin adetini belirtiniz");
            int adet = Convert.ToInt32(Console.ReadLine());
            List<int> sayilistesi = new List<int>();
            List<double> sonuclistesi = new List<double>();
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine($"{i+1}. sayiyi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayilistesi.Add(sayi);
            }
            for (int i = 0;i < sayilistesi.Count; i+=2)
            {
                int sayi1 = sayilistesi[i];
                int sayi2 = sayilistesi[i+1];

                if(sayi1 != sayi2)
                {
                    int toplam = sayi1 + sayi2;
                    sonuclistesi.Add(toplam);

                }
                else
                {
                    double karesi = Math.Pow(sayi1+sayi2,2);
                    // Karesini alma matematik kutuphanesi double degisken dondurdugu icin karesi degiskeninin tipini double yaptim.
                    sonuclistesi.Add(karesi);
                }
            }
            Console.WriteLine("***************Sonuc Listesi************");
            foreach (int i in sonuclistesi)
            { Console.WriteLine(i); }
        }
    }
}