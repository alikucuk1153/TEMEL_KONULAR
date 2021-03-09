using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // interfaceler kullanıırken içerisindeki metotlarıda içermek zorundadır.
    // ımplement interface diyererk (Ara birimi uygula) otomatik oluşturula bilir.
    class TasitKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplaması yapıldı.");
        }
    }
}
