using System;
using System.Collections.Generic;
using System.Text;

namespace OOP33
{
    class IhtiyacKrediManager : ICreditManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç Kredisi Ödeme Planı Hesaplanı");
        }
    }
}
