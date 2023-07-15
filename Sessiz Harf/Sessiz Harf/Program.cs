namespace Sessiz_Harf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime yaziniz ");
            string kelime = Console.ReadLine();
            
            SessizHarfKontrolu(kelime);
           

        }
        public static void  SessizHarfKontrolu( string kelime)
        {
            string sessizHarfler = "bcdfghjklmnprstvyz";
            int sayac = 0;
            for (int i = 0; i < kelime.Length-1; i++)
            {
                if (sessizHarfler.Contains(kelime[i]) && sessizHarfler.Contains( kelime[i+1]))
                {
                    sayac++;
                   
                }
                
            }
            if (sayac > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}