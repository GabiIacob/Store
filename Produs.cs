using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr2_Magazin
{
    [Table("Produs")]
    public class Produs
    {
        [Key]
        public int ID { get; set; }

        [MaxLength(30, ErrorMessage = "Maxim 30 de caractere")]
        public string Denumire { get; set; }

        public string Descriere { get; set; }


        public string DataIntrare { get; set; }

        public string DataIesire { get; set; }
        public string DataExpirare { get; set; }

        public int Cantitate { get; set; }

        public int idCategorie { get; set; }
    }

    public class ProdusDbContext : DbContext
    {
        public ProdusDbContext() : base("name=Pr2_MagazinDbContext")
        {
            
        }

        
        public DbSet<Produs> Produse { get; set; }
        public DbSet<CategorieProdus> CategoriiProduse { get; set; }
        public DbSet<IstoricVanzari> IstoricVanzari { get; set; }
        public DbSet<Users> users { get; set; }


    }
}
