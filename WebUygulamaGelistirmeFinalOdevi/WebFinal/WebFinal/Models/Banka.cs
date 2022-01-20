using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinal.Models
{
    public class Banka
    {
        public virtual int Id { get; set; }
        public virtual String Ad { get; set; }
        public virtual String Soyad { get; set; }
        public virtual String Telefon { get; set; }
        public virtual String Sehir { get; set; }
        public virtual String Ilce { get; set; }
        public virtual String Banka_Ad { get; set; }
        public virtual ICollection<Models.Sube> Subeler { get; set; } = new List<Models.Sube>();
    }

    public class BankaMap : ClassMapping<Banka>
    {
        public BankaMap()
        {
            Table("Banka");

            Id(x => x.Id, m => m.Generator(Generators.Native)); //primary key
            Property(x => x.Ad, c => c.Length(20));
            Property(x => x.Soyad, c => c.Length(20));
            Property(x => x.Telefon, c => c.Length(20));
            Property(x => x.Sehir, c => c.Length(20));
            Property(x => x.Ilce, c => c.Length(20));
            Property(x => x.Banka_Ad, c => c.Length(20));
            Set(e => e.Subeler,
                mapper =>
                {
                    mapper.Key(k => k.Column("Banka"));
                    mapper.Inverse(true);
                    mapper.Cascade(Cascade.All);

                },

                relation => relation.OneToMany(mapping => mapping.Class(typeof(Sube))));

        }
    }
}
