using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Abstract
{
    public class Fatura
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(12)]
        public char FaturaSeriNo { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSıraNo { get; set; }
        public DateTime Tarih { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string VergiDairesi { get; set; }

        public DateTime saat { get; set; }



        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimEden { get; set; }


        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string TeslimAlan { get; set; }
        public  ICollection<FaturaKalem> faturaKalems { get; set; }
    }
}
