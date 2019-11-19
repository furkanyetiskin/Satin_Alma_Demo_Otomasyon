using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SatinAlma.Entities.Models
{
    public partial class Personeller:IEntity
    {
        public Personeller()
        {
            this.UrunSatinAlims = new List<UrunSatinAlim>();
        }
      
        public int PersonelID { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string TCKN { get; set; }
        public string Gorevi { get; set; }
        public int DepartmanID { get; set; }
        public System.DateTime IseGirisTarihi { get; set; }
        public string TelNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public Nullable<bool> AlisYetkiliMi { get; set; }
        public Nullable<bool> AktifMi { get; set; }
        public virtual Departmanlar Departmanlar { get; set; }
        public virtual ICollection<UrunSatinAlim> UrunSatinAlims { get; set; }

        

    }
}
