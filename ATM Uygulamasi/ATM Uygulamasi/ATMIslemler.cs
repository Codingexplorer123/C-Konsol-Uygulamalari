using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ATM_Uygulama
{
    public class ATMIslemler
    {
        List<Transaction> transactionkayidi = new List<Transaction>();

        double bakiye = 3000;
        public void BakiyeSorgu()
        {
            Console.WriteLine($"Bakiyeniz: {bakiye}");
        }

        public void ParaCekimi()
        {
            Console.WriteLine("Cekmek istediginiz tutari belirtiniz");
            double tutar;
            if (!double.TryParse(Console.ReadLine(), out tutar))
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

                    Transaction transaction = new Transaction(1, "ParaCekimi", tutar);
                    transactionkayidi.Add(transaction);
                }
            }

        }
        public void ParaYatirma()
        {
            Console.WriteLine("Yatirmak istediginiz tutari girin");
            double yatirilan;
            if (!double.TryParse(Console.ReadLine(), out yatirilan))
            {
                Console.WriteLine("Lutfen 0 dan buyuk sayisal bir deger giriniz");
            }
            else
            {
                bakiye += yatirilan;
                Console.WriteLine($"Isleminiz gerceklesmistir. Guncel Bakiyeniz {bakiye}");

                Transaction transaction = new Transaction(1, "ParaYatirma", yatirilan);
                transactionkayidi.Add(transaction);
            }
        }

        public List<Transaction> GetTransaction()
        {
            return transactionkayidi;
        }
    }

}
