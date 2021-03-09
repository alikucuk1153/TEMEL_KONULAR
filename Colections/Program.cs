﻿using System;
using System.Collections.Generic;

namespace Collections  // array lerde oluşturduktan sonra herhangi bir yerde array e eleman ekleme işlemi yapılamadığı için koleksiyonları kullanırız.
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Ali", "Mehmet", "Osman", "Veli" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            isimler.Add("İlker");

            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[2]);



        }
    }
}
