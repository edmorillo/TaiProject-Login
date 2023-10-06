using System.ComponentModel.DataAnnotations.Schema;

namespace TaiProject.Models
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string? Username { get; set; }

        public string? Clave { get; set; }

        [NotMapped]
        public bool MantenerActivo { get; set; }
    }
}
