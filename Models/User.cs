using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KomunikatorTekstowy.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("id")]

        public int Id {get; set;}
        [Required]

        [Column("nickname")]
        public string Nickname { get; set; }

        [Column("Password")]
        public string Password { get; set; }




    }
}
