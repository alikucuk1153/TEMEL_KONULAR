using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;   // referans numaraları kalıcı olsun diye geçici dizi yapıldı.
            items = new T[items.Length + 1];
            for (int i = 0; i < items.Length; i++)
            {
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item;
        }

    }
}
