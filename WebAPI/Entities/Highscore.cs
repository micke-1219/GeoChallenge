using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Entities
{
    [Table("Highscore")]
    public partial class Highscore
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        [Required]
        [StringLength(6)]
        public string PlayerName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Required]
        [StringLength(50)]
        public string Game { get; set; }
    }
}
