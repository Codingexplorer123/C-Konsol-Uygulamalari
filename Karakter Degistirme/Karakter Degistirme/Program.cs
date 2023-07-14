namespace Karakter_Degistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool dongu = true;
            do
            {
                Console.WriteLine("Bir Kelime Yaziniz");
                string kelime = Console.ReadLine();
                char[]chardizisi = kelime.ToCharArray();
                foreach (var harf in chardizisi)
                {
                    var degisken = chardizisi[0];
                    chardizisi[0] = chardizisi[kelime.Length - 1];
                    chardizisi[kelime.Length-1] = degisken; 
                }
                foreach (var harf in chardizisi)
                {
                    Console.Write(harf);
                };
                Console.WriteLine(" ");
                Console.WriteLine("Cikmak icin 1 e basin devam icin baska bir tusa basin");
                char secim = Convert.ToChar(Console.ReadLine());
                if (secim == '1')
                {
                    dongu = false;
                }
                Console.ReadKey();
            } while (dongu);
        }
    }
}