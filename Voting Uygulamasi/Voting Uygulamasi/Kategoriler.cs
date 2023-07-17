using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Voting_Uygulamasi
{
    public class Kategoriler
    {
        // Pre defined categorie olusturulmasi istendiginden asagida bir category listesi yapip ornekteki uc kategoriyi listeye default olarak ekleyecegiz.
        List<string> Kategori = new List<string>() { "a-)Filmler", "b-)Tech Stack", "c-)Spor" };
        // Kategorilere verilen oylari saymak icin 3 tane kategori icin 3 degisken tanimlayip baslangic degerini sifir alip her oy verdiginde
        //artiracagiz
        int a=1, b=1, c = 1;
        public void  KategoriSecimi()
        {
            // Simdi kullaniciya kategorileri gosterip hangi kategoride oy kullanacaksa secim yapmasi istenecek
            foreach (var item in Kategori)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Yukaridaki kategorilerden birini seciniz\t a,b veya c(kucuk harfle) giriniz");
            string secim = Console.ReadLine();
            switch (secim)
            {
                case "a":
                    a += 1;
                    break;
                case "b":
                    b +=1;
                    break;
                case "c":
                    c += 1;
                    break;
            }
            

        }

        public void OylamaSonucu()
        {
            Console.WriteLine($"Verilen oy sayisi: {a+b+c}, Filmler Kategorisinin oy sayisi {a} aldigi oy orani % {100 * a/(a+b+c)}\n" +
                $"Tech Stack Kategorisinin oy sayisi {b} aldigi oy orani % {100 * b/(a+b+c)}\n" +
                $"Spor Kategorisinin oy sayisi {c} aldigi oy orani % {100 * c/(a+b+c)}" );
        }

       

    }
}
