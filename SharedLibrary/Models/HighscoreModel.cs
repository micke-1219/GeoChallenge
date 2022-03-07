using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class HighscoreModel
    {
        public int Id { get; set; }
        public int Score { get; set; }
        [Required(ErrorMessage = "Name must be between 1 and 6 characters long.")]
        [MinLength(1, ErrorMessage = "Name must be between 1 and 6 characters long.")]
        [MaxLength(6, ErrorMessage = "Name must be between 1 and 6 characters long.")]
        public string PlayerName { get; set; }
        public DateTime Date { get; set; }
        public string Game { get; set; }
    }
}
