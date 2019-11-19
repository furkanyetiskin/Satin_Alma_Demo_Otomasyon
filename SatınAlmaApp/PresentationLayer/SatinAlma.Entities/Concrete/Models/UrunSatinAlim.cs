using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SatinAlma.Entities.Models
{
    public partial class UrunSatinAlim:IEntity
    {
        public UrunSatinAlim()
        {
            this.SatinAlmaDetays = new List<SatinAlmaDetay>();
        }

        public int SatinAlimID { get; set; }
        public Nullable<int> PersonelID { get; set; }
        public Nullable<System.DateTime> SatinAlimTarihi { get; set; }
        public decimal NakliyeUcreti { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public virtual Tedarikciler Tedarikciler { get; set; }
        public virtual Personeller Personeller { get; set; }
        public virtual ICollection<SatinAlmaDetay> SatinAlmaDetays { get; set; }
    }
}
