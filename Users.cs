using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pr2_Magazin
{
    [Table("Users")]
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Produs {  get; set; }
        public int Cantitate { get; set; }

        private static string currentUsername;
        public static string CurrentUsername
        {
            get { return currentUsername; }
            set { currentUsername = value; }
        }

    }
}



