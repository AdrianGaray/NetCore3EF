using System.Collections.Generic;

namespace Sistemawebcf.Models
{
    public class Categoria
    {
        public int idcategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public bool? estado { get; set; }
        public virtual ICollection<Producto> producto { get; set; }
    }
}
