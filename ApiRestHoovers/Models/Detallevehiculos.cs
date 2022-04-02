using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestHoovers.Models
{
    public class DetalleVehiculos
    {
        public string Marca { get; set; }
        public string linea { get; set; }
        public string Tipo { get; set; }
        public int modelov { get; set; }
        public int Total_C { get; set; }
    }
}
