using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SatinAlma.Entities.Models
{
    public partial class Kategoriler:IEntity
    {
        public Kategoriler()
        {
            this.Urunlers = new List<Urunler>();
        }

        public int KategoriID { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public Nullable<bool> AktifMi { get; set; }
        public virtual ICollection<Urunler> Urunlers { get; set; }
    }
}
