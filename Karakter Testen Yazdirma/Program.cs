namespace Karakter_Testen_Yazdirma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime giriniz");
            string kelime = Console.ReadLine();
            TersYazma(kelime);
        }
        static void TersYazma(string kelime)
        {
            var kelimelist = kelime.ToList();
            
            for (int i = 0; i<kelime.Length-1; i++)
            {
                var gecicidegisken = kelimelist[i];
                kelimelist[i] = kelime[i + 1];
                kelimelist[i+1] = gecicidegisken;
                if(i -1 == kelime.Length)
                {
                    gecicidegisken = kelimelist[kelime.Length-1];
                    kelimelist[i + 1] = kelimelist[0];
                    kelimelist[i] = gecicidegisken;
                }

            }
            
            foreach (var harf in kelimelist)
            {
                Console.Write(harf);
            }
        }
    }
}