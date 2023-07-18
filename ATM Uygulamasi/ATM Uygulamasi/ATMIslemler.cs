using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class ATMIslemler
    {
        double bakiye = 3000;
        Transaction transaction = new Transaction();

        public void BakiyeSorgu()
        {
            Console.WriteLine($"Bakiyeniz: {bakiye}");
        }

        public void ParaCekimi()
        {
            Console.WriteLine("Cekmek istediginiz tutari belirtiniz");
             double tutar;
            if (!double.TryParse(Console.ReadLine(),out tutar))
            {
                Console.WriteLine("Lutfen 0 dan buyuk sayisal bir deger giriniz");
                
            }
            else
            {
                if (tutar <= 0 || tutar > bakiye)
                {
                    Console.WriteLine("Bakiye uzeri tutar veya negatif bir tutar girmeyiniz.");
                    
                }
                else
                {
                    bakiye -= tutar;
                    Console.WriteLine($"Isleminiz gerceklesmistir. Guncel Bakiyeniz {bakiye}");
                    transaction.IslemTuru = "Para Cekimi";
                    transaction.Tutar = tutar;
                    transaction.Tarih = DateTime.Now;



                }
            }
            
        }
        public void ParaYatirma()
        {
            Console.WriteLine("Yatirmak istediginiz tutari girin");
            double yatirilan;
            if(!double.TryParse(Console.ReadLine(), out yatirilan))
            {
                Console.WriteLine("Lutfen 0 dan buyuk sayisal bir deger giriniz");
            }
            else
            {
                bakiye += yatirilan;
                Console.WriteLine($"Isleminiz gerceklesmistir. Guncel Bakiyeniz {bakiye}");
                transaction.IslemTuru = "Para Yatirma";
                transaction.Tutar = yatirilan;
                transaction.Tarih = DateTime.Now;
            }
        }
    }


}
