using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace ApiCoreRestsv.models
{
    public class Comentario
    {
        public int id { get; set; }
        [Required]
        public string titulo { get; set; }
        [Required]
        public string creador { get; set; }
        [Required]
        public string titutexto { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
