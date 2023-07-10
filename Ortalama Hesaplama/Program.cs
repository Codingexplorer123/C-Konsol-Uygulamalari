namespace Ortalama_Hesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonanci sayisilari dizisi nereye kadar olsun");
            int derinlik = Convert.ToInt32(Console.ReadLine());
            
            FibonanciSerisi(derinlik);





        }
        public static void FibonanciSerisi(int derinlik)
        {
            Console.WriteLine("Fibonacci Series:");

            int sayi1 = 0;
            int sayi2 = 1;
            int sayi3 = 0;
            double[] sayilar = new double[derinlik];
            

            for (int i = 0; i < derinlik; i++)
            {
                Console.WriteLine(sayi1);
                

                sayi3 = sayi1 + sayi2;
                sayi1 = sayi2;
                sayi2 = sayi3;
                sayilar[i] = sayi1; 
            }
            double ortalama = 0;
            foreach (var sayi in sayilar)
            {
                ortalama += sayi / derinlik;
            }
            Console.WriteLine("Fibonanci sayilarin ortalamasi :" + ortalama);


        }
        
    }
    
}