﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri    // Musteride olan hersey GercekMusteride de kabul edilir demek
    {
       
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}