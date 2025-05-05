using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2_Magazin
{
    [Table("IstoricVanzari")]

    public class IstoricVanzari
    {
        [Key]
        public int Id { get; set; }
        public int IdProdus { get; set; }
        public int Cantitate { get; set; }
    }
}
