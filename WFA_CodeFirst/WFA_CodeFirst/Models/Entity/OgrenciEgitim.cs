using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CodeFirst.Models.Entity
{
    class OgrenciEgitim
    {



        [Key]
        [Column(Order =1)]
        public int OgrenciID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int EgitimID { get; set; }


        //Mapping
        public Ogrenci Ogrenci { get; set; }
        public Egitim Egitim { get; set; }
    }
}
