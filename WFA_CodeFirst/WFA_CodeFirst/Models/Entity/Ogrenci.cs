using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CodeFirst.Models.Entity
{
    class Ogrenci
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string TCKimlikNo { get; set; }
        public string Acikalama { get; set; }

        //Mapping   
        public IEnumerable<OgrenciEgitim> OgrenciEgitimleri { get; set; }
    }
}
