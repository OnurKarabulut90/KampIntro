using System;
using System.Collections.Generic;
using System.Text;

namespace OOP33
{
    class EsnafKrediManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf Kredisi Hesaplandı");
        }
    }
}
