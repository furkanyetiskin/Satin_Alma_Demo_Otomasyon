using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SatinAlma.Entities.Models
{
    public partial class Urunler:IEntity
    {
        public Urunler()
        {
            this.SatinAlmaDetays = new List<SatinAlmaDetay>();
        }

        public int UrunID { get; set; }
        public string Adi { get; set; }
        public decimal Fiyat { get; set; }
        public short Stok { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<bool> AktifMi { get; set; }
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual ICollection<SatinAlmaDetay> SatinAlmaDetays { get; set; }
        public virtual Tedarikciler Tedarikciler { get; set; }
    }
}
