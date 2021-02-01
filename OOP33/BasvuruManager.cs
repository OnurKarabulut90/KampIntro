using System;
using System.Collections.Generic;
using System.Text;

namespace OOP33
{
    class BasvuruManager
    {
        //Method injecti
        public void BasvuruYap(ICreditManager creditManager, ILoggerService loggerService)
        {
            //Başvuranın Bilgilerinin Değerlendirme
            //
            creditManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
