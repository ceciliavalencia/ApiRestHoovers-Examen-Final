using System;
using System.Collections.Generic;

#nullable disable

namespace ApiRestHoovers.Models
{
    public partial class Bitacora
    {
        public int Id { get; set; }
        public int? IdModulo { get; set; }
        public int? IdMetodo { get; set; }
        public string Json { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string Usuario { get; set; }

        public virtual Metodo IdMetodoNavigation { get; set; }
        public virtual Modulo IdModuloNavigation { get; set; }
    }
}
