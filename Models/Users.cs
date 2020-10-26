using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KomunikatorTekstowy.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        [Column("id")]

        public int Id { get; set; }
        [Required]
        [Column("nickname")]

        public string Nickname { get; set; }

        [Required]
        [Column("password")]

        public string Password { get; set; }

    }
}