using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = "Elma";
            double price = 15;
            string description = "Amasya Elması";

            string[] meyveler = new string[] { };

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };

            //type-safe -- Tip Güvenli
            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("----------------");
            }

            Console.WriteLine("------Metotlar------");
            //instance "class örneği oluşturmak"
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(product1);
            sepetmanager.Ekle(product2);

            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 9);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 12, 10);
            sepetmanager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12, 7);
            //encapsolution "düzen içerisinde çalışmak"
            
        }
    }
}


// Metotlar tekrar tekrar kullanılabilirliği sağlayan bir kod bloklarıdır.
// Don't repaet yourself. DRY