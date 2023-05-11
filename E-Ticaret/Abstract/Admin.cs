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
    public class Admin
    {
        [Key]
        public  int Id { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(10)]
        public string KullaniciAdi { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KullaniciSifre { get; set; }

        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string KullaniciYetki { get; set; }

    }
}
