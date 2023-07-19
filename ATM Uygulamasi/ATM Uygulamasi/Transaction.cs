using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulama
{
    public class Transaction
    {
        public int KullaniciID { get; set; }
        public string IslemTuru { get; set; }
        public double Tutar { get; set; }

        public DateTime Tarih { get; set; }


        public Transaction(int kullaniciID, string islemTuru, double tutar)
        {
            KullaniciID = kullaniciID;
            IslemTuru = islemTuru;
            Tutar = tutar;
            Tarih = DateTime.Now;
        }
    }
}
