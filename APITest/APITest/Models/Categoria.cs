using System.ComponentModel.DataAnnotations;

namespace APITest.Models
{
    public class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }

        public string Nombre { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
