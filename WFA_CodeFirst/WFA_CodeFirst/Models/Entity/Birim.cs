using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WFA_CodeFirst.Models.Entity
{
    [Table("Units")]
    class Birim
    {
        [Key]//primarykey
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//indetity özelliği
        public int ID { get; set; }

        [MaxLength(50,ErrorMessage ="Ad 50 KArakteri Geçemez")]
        [Column("Name",TypeName ="varchar")]
        [Required(ErrorMessage ="Birim Adı Boş Geçilemez.")]
        public string Ad { get; set; }

        [MaxLength(250, ErrorMessage = "Aciklama 250 KArakteri Geçemez")]
        [Column(TypeName = "varchar")]
        public string Aciklama { get; set; }

        //Maping
        public IEnumerable<Egitim> Egitimler { get; set; }
    }
}
