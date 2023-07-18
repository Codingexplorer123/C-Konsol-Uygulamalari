using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Uygulamasi
{
    public class Transaction
    {
        public string IslemTuru { get; set; }
        public double Tutar { get; set; }

        public DateTime Tarih { get; set; }

        List<Transaction> transactionLog = new List<Transaction>();

    }

    public void GunSonuIslem()
    {
        Console.WriteLine("Gun sonu raporu hazirlaniyor");

        string rapor = "Gun Sonu Raporu\n";
        rapor += "---------------------\n";

        foreach ( var transaction in transactionLog)
        {

        }
    }
}
