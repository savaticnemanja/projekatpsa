using System;
using System.ComponentModel.DataAnnotations;

namespace ProjekatPsa.Models
{
    public class Kandidat : Osoba
    {
        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumRodjenja { get; set; }

        [Required]
        [StringLength(13, MinimumLength = 13)]
        public string Jmbg { get; set; }
    }
}
