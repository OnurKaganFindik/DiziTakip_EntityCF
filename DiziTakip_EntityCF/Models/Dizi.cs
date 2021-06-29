using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziTakip_EntityCF.Models
{
    [Table("Diziler")]
   public class Dizi
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Ad { get; set; }
        public int Sezon { get; set; }
        public int Bolum { get; set; }
        public bool BittiMi { get; set; }


    }
}
