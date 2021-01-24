using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //Naming convention "isimlendirme kuralları"
        //syntax "Yazım şekilleri"
        //Eklemek istediğimizi metoda vermek "Parametre" yani (Urun urun)
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + product.Name + product.Description + product.Price);
            //Product's adını girdiğimiz için Program.cs de SepetManager de karşısına ürün ile ilgili
            //istediğin parametreleri çağırabilirsin.
        }
        public void Ekle2(string productName, double description, string price, int stokAdedi)
            //yukarıda ki ürünlerin tamamını içeren metoda encapsulation deniyor.
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + productName + description + price);

        }
    }
}
