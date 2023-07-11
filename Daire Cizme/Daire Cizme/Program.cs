namespace Daire_Cizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dairenin Yaricapi degerini pozitif tam sayi olarak giriniz");
            int radius = Convert.ToInt32(Console.ReadLine());
            DaireCizme(radius);
        }
        public static void DaireCizme(int radius)
        {
            
            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    if (x * x + y * y <= radius * radius)
                    {
                        Console.Write("*"); // Dairenin içi
                    }
                    else
                    {
                        Console.Write("d "); // Dairenin dışı
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}