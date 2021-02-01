using System;

namespace OOP33
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı");
        }
    }
}
