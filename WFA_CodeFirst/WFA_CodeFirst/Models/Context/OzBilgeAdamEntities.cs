using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WFA_CodeFirst.Models.Entity;
namespace WFA_CodeFirst.Models.Context
{
    //using Models;
    class OzBilgeAdamEntities:DbContext
    {

        //public OzBilgeAdamEntities():base("server=.;database=OZBA;uid=sa;pwd=12345678;MultipleActiveResultSets=true")
        //{

        //}
        public OzBilgeAdamEntities():base("OzBilgeAdamCon")
        {
            //projemizin Ayar Dosyasından Çeker
        }

        public DbSet<Egitim> Egitimler { get; set; }
        public DbSet<Birim> Birimler { get; set; }
        public DbSet<Etiket> Etiketler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgrenciEgitim> OgrenciEgitimleri { get; set; }

    }
}
