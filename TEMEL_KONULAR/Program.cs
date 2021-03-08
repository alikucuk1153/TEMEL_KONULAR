using System;

namespace METOTLAR
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product1 = new Product();    //  instanse - class ın örneği denir.
            product1.Adi = "Elma";
            product1.Fiyat = 15;
            product1.Aciklama = "Amasya Elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyat = 80;
            product2.Aciklama = "Adana Karpuzu";

            Product[] Products = new Product[] { product1, product2 };

            foreach (Product product in Products)    // type safe  tip güvenliği
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyat);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("--------------");
            }

            Console.WriteLine("-----Metot-----");

            // reuse ability  -  metotlar ve fonksiyonlar birçok sayfada tekrar kullanma imkanı sağlamaktadır.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);



        }
    }
}
