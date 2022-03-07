using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebAPI.Entities
{
    [Table("Country")]
    public partial class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Capital { get; set; }
        [Required]
        [StringLength(15)]
        public string Population { get; set; }
        [Required]
        public byte[] Flag { get; set; }
        [Required]
        [StringLength(10)]
        public string Size { get; set; }
    }
}
