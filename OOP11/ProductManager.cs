using System;
using System.Collections.Generic;
using System.Text;

namespace OOP11
{   //"İçerisinde çeşitli operasyonlar var olduğunu belirtir."
    class ProductManager
    {   //encapsulation
        public void Add(Product product) //"Parametre yapısı"
        {
            product.ProductName = "Kamera";

        }
        public void BirseyYap(int sayi)
        {
            sayi = 99;
        }
    }
}
