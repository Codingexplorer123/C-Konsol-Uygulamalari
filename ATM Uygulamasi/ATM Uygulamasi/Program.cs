namespace ATM_Uygulamasi
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "ATM App";
            // Console ismini degistirdim.
            Console.WriteLine("Lutfen Atm Kartinizi yerlestiriniz.");
            bool kontrol = true;
            Menu menu = new Menu();
            ATMIslemler aTM = new ATMIslemler();  
            Rapor rapor = new Rapor();
            KullaniciKimlikDogrulama kullaniciKimlikDogrulama =new KullaniciKimlikDogrulama();
            bool sonuc =kullaniciKimlikDogrulama.KimlikDogrulama();
            if (sonuc == true)
            {
                menu.AnaMenuGoster();
                byte secim =Convert.ToByte(Console.ReadLine());
                menu.AnaMenuKontrol(secim);
                bool dongu = true;
                while (dongu)
                {
                    switch (secim)
                    {
                        case 1:
                            aTM.BakiyeSorgu();
                            break;
                        case 2:
                            aTM.ParaCekimi();
                            break;

                        case 3:
                            aTM.ParaYatirma();
                            break;

                        case 4:
                            Console.WriteLine("Programdan cikis yapiliyor");
                            Environment.Exit(0);
                            break;

                        case 5:
                            rapor.GunSonuIslemi();
                            break;
                    }
                    Console.WriteLine("ATM den cikma icin e ye devam etmek icin herhangi bir tusa basiniz");
                    char cikis = Convert.ToChar(Console.ReadLine().ToLower());
                    if (cikis == 'e') { dongu = false; }
                }
                  
            }
            else
            {
                Console.WriteLine("Atm Kapatiliyor");
                Environment.Exit(0);
            }

        }
    }
}