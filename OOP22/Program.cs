using System;

namespace OOP22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCostumer costumer1 = new IndividualCostumer();
            costumer1.MusteriNo = "12345";
            costumer1.Adi = "Engin";
            costumer1.Soyadi = "Demiroğ";
            costumer1.TcNo = "1234567890";

            //Kodlama.io
            CoorporetCostumer costumer2 = new CoorporetCostumer();
            costumer2.Id = 2;
            costumer2.MusteriNo = "54321";
            costumer2.SirketAdi = "Kodlama.io";
            costumer2.VergiNo = "1234567890";

            //Gerçek Müşteri - Tüzel Müşteri
            //SOLID

            Costumer costumer3 = new CoorporetCostumer();
            Costumer costumer4 = new IndividualCostumer();

            CostumerManager costumerManager = new CostumerManager();
            costumerManager.Add(costumer1);
            costumerManager.Add(costumer2);
            costumerManager.Add(costumer3);
            costumerManager.Add(costumer4);
        }
    }
}
