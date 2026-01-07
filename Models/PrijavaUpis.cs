using System;
using System.ComponentModel.DataAnnotations;

namespace ProjekatPsa.Models
{
    public class PrijavaUpis
    {
        public int Id { get; set; }

        [Required]
        public Kandidat Kandidat { get; set; }

        [Required]
        public int StudijskiProgramId { get; set; }

        public StudijskiProgram StudijskiProgram { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DatumPrijave { get; set; }

        [StringLength(200)]
        public string Napomena { get; set; }
    }
}
