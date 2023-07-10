namespace Ucgen_Cizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ucgenin kisa kenarlarinin boyutunu pozitif tam sayi olarak giriniz");
            int uzunluk = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < uzunluk; i++)
            {
                
                for (int j = 0; j < uzunluk; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("*");
                    }
                    
                }
                Console.WriteLine("");
            }
        }
    }
}