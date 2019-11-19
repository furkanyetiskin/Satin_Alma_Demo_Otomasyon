using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SatinAlma.Entities.Models
{
    public partial class SiparisDurumu:IEntity
    {
        public SiparisDurumu()
        {
            this.SatinAlmaDetays = new List<SatinAlmaDetay>();
        }

        public int DurumID { get; set; }
        public string SiparisDurum { get; set; }
        public virtual ICollection<SatinAlmaDetay> SatinAlmaDetays { get; set; }
    }
}
