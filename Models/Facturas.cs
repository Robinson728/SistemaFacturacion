using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaFacturacion.Models
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        public int NoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }
        public double ITBIS { get; set; }
        public bool Pagado { get; set; }
        public int TipoPago { get; set; }
    }
}
