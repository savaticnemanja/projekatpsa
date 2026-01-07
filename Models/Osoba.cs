using System.ComponentModel.DataAnnotations;

namespace ProjekatPsa.Models
{
    public abstract class Osoba
    {
        [Required]
        [StringLength(40)]
        public string Ime { get; set; }

        [Required]
        [StringLength(40)]
        public string Prezime { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string Telefon { get; set; }
    }
}
