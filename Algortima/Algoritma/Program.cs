namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir kelime yaziniz");
            string kelime = Console.ReadLine();
            Console.WriteLine("index numarasi giriniz");
            int index = Convert.ToInt32(Console.ReadLine());
            Algoritma(kelime, index);

        }
        public static void Algoritma(string kelime, int index)
        {

            var kelimelist = kelime.ToList();
            try
            {
                kelimelist.RemoveAt(index);
                // RemoveAt o index deki listede bulunan degeri siler.
                foreach (var item in kelimelist)
                {
                    Console.Write(item);
                }
            }
            catch (Exception)
            {

                Console.WriteLine(kelime);
            }
           
        }  

 
        
    }
}