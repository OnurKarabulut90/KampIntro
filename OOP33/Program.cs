using System;
using System.Collections.Generic;

namespace OOP33
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            EsnafKrediManager esnafKrediManager = new EsnafKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService(); 
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new CalisanKrediManager(), smsLoggerService);

            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacKrediManager, tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
