using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models
{
    public class Productos
    {
        [Key]

        public int ProductoId { get; set; }
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public int Stock { get; set; }
        public double PrecioVenta { get; set; }
        public double PrecioCompra { get; set; }
    }
}
