using System;
using System.Collections.Generic;
using System.Text;

namespace METOTLAR
{
    class SepetManager
    {
       // naming convention 
       // syntax
       // (***) olayı fonksiyona parametre atama işlemi
        public void Ekle(Product product)   //  metot yazılımı. () işareti var ise bu bir metot demektir.
        {

            Console.WriteLine("Sepete eklendi : " + product.Adi);
        
        }

    }
}
