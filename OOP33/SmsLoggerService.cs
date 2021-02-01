using System;
using System.Collections.Generic;
using System.Text;

namespace OOP33
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms Yollandı");
        }
    }
}
