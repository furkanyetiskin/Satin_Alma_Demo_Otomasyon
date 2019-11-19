using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SatinAlma.Entities.Models
{
    public partial class SatinAlmaDetay:IEntity
    {
        public int UrunID { get; set; }
        public int SatinAlimID { get; set; }
        public int DurumID { get; set; }
        public Nullable<System.DateTime> AlinmaTarihi { get; set; }
        public Nullable<decimal> Fiyat { get; set; }
        public Nullable<double> Adet { get; set; }
        public virtual SiparisDurumu SiparisDurum { get; set; }
        public virtual Urunler Urunler { get; set; }
        public virtual UrunSatinAlim UrunSatinAlim { get; set; }
    }
}
