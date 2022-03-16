using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WFA_CodeFirst.Models.Entity
{
    class Egitim
    {
        public int ID { get; set; }
        public string Adi { get; set; }

        //[ForeignKey("EgitimBirimi")]
        public int BirimID { get; set; }
        public string Sure { get; set; }
        public bool SertifikaVerilirmi { get; set; }
        public bool SınavYapilirmi { get; set; }
        public string Aciklama { get; set; }
        public string Seviye { get; set; }

        //Mapping
        public Birim Birim { get; set; }
        public IEnumerable<OgrenciEgitim> OgrenciEgitimleri { get; set; }
    }
}
