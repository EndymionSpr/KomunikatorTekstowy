using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KomunikatorTekstowy.Models
{
    [Table("Chats")]
    public class Chats
    {
        [Key]
        [Column("id")]

        public int Id { get; set; }
        [Required]

        [Column("user_id")]
        public int User_id { get; set; }

        [Column("path")]
        public string Path { get; set; }

    }
}
