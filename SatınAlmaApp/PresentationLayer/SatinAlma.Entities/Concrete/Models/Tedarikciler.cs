using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SatinAlma.Entities.Models
{
    public partial class Tedarikciler:IEntity
    {
        public Tedarikciler()
        {
            this.Urunlers = new List<Urunler>();
        }

        public int TedarikciID { get; set; }
        public string SirketAdi { get; set; }
        public string Adres { get; set; }
        public string Sehir { get; set; }
        public string TelNo { get; set; }
        public Nullable<bool> AktifMi { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
        public virtual ICollection<UrunSatinAlim> UrunSatinAlims { get; set; }
    }
}
