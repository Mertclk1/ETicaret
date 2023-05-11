using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Abstract
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunAdi { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string UrunMarka { get; set; }


        public short Stok { get; set; }
        public decimal AlisFiyati { get; set; }
        public decimal SatisFiyati { get; set; }
        public bool Durum { get; set; }



        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string UrunGorsel { get; set; }



        public SatisHareketleri satisHareketleri { get; set; }
        public Katagori Katagori { get; set; } //bire çok ilişki
    }
}
