using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinal.Models
{
    public class Sube
    {
        public virtual int Id { get; set; }
        public virtual String Ad { get; set; }
        public virtual String Soyad { get; set; }
        public virtual String Telefon { get; set; }
        public virtual String Banka_Ad { get; set; }
        public virtual Banka Banka { get; set; }
    }

    public class SubeMap : ClassMapping<Sube>
    {
        public SubeMap()
        {
            Table("Sube");
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.Ad, c => c.Length(20));
            Property(x => x.Soyad, c => c.Length(20));
            Property(x => x.Telefon, c => c.Length(20));
            Property(x => x.Banka_Ad, c => c.Length(20));
            ManyToOne(x => x.Banka);



        }

    }
}
