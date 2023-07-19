using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    
    public class Transaction
    {
        public int KullaniciID { get;}
        public string IslemTuru { get;}
        public double Tutar { get; }

        public DateTime Tarih { get;}

        List<Transaction> transactionkayidi = new List<Transaction>();
        public Transaction (int kullaniciID , string islemTuru, double tutar)
        {
            KullaniciID = kullaniciID;
            IslemTuru = islemTuru;
            Tutar = tutar;
            Tarih = DateTime.Now;
        }
        
        

      
        
        

    }

  
}
