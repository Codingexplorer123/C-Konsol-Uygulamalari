using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class Rapor
    {
        Transaction kayit = new Transaction();
        public void GunSonuIslemi()
        {
            Console.WriteLine("Gun sonu Raporu olusturuluyor");

            string rapor = "Gun sonu Raporu\n";
            rapor += "---------------";

            ATMIslemler islemler = new ATMIslemler();
            foreach (var transaction in transactionkayidi)
            {
                rapor += $"{transaction.Tarih.ToString("dd/MM/yyyy HH:mm:ss")} -{transaction.IslemTuru} -{transaction.Tutar}\n";
            }

            transactionkayidi.Add(new Transaction(1, "Hatali Giris", 0));

            string tarihFormatli = DateTime.Now.ToString("ddMMyyyy");
            string dosyaYolu = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"IslemKaydi_{tarihFormatli}.txt");
            File.WriteAllText(dosyaYolu, rapor);
            Console.WriteLine("Gun sonu raporu olusturuldu");

        }
    }
}
