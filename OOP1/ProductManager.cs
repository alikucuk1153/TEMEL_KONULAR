using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " ürün eklendi.");
        }

        public void Updeta(Product product)
        {
            Console.WriteLine(product.ProductName + " ürün güncellendi.");
        
        }
    }
}
