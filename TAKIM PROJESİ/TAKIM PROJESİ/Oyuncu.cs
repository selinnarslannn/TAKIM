//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TAKIM_PROJESİ
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oyuncu
    {
        public int OyuncuNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yas { get; set; }
        public string Mevki { get; set; }
        public decimal Maas { get; set; }
        public string Ulke { get; set; }
        public int TakimNo { get; set; }
        public int MevkiNo { get; set; }
    
        public virtual Takim Takim { get; set; }
        public virtual Mevki Mevki1 { get; set; }
    }
}
