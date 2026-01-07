using System.ComponentModel.DataAnnotations;

namespace ProjekatPsa.Models
{
    public class StudijskiProgram
    {
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(120)]
        public string Opis { get; set; }

        [Range(1, 6)]
        public int TrajanjeSemestara { get; set; }
    }
}
