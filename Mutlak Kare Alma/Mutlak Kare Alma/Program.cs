using System.ComponentModel;

namespace Mutlak_Kare_Alma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Consoldan girmek istediginiz sayi adedini belirtiniz");
            int adet = Convert.ToInt32(Console.ReadLine());
            List<int> sayilistesi = new List<int>();
            int kucuktoplam = 0;
            double buyuktoplam = 0;
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine($"{i + 1} sayiyi giriniz.");
                sayilistesi.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach (int i in sayilistesi)
            {
                if (i <= 67)
                {
                   kucuktoplam += (67-i);
                }
                else
                {
                    buyuktoplam += Math.Pow((i - 67),2);
                }
            }
            Console.WriteLine($"Output: {kucuktoplam} ve {buyuktoplam}");
        }
    }
}