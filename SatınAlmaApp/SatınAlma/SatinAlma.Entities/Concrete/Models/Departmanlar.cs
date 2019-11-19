using SatinAlma.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace SatinAlma.Entities.Models
{
    public partial class Departmanlar:IEntity
    {
        public Departmanlar()
        {
            this.Personellers = new List<Personeller>();
        }

        public int DepartmanID { get; set; }
        public string Adi { get; set; }
        public virtual ICollection<Personeller> Personellers { get; set; }
    }
}
