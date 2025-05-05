using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Pr2_Magazin
{
    [Table("CategorieProdus")]
    public class CategorieProdus
    {
        [Key]
        public int Id { get; set; }
        public string Denumire {  get; set; }
    }
}
