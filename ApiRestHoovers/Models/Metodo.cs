using System;
using System.Collections.Generic;

#nullable disable

namespace ApiRestHoovers.Models
{
    public partial class Metodo
    {
        public Metodo()
        {
            Bitacoras = new HashSet<Bitacora>();
        }

        public int Id { get; set; }
        public string Tipo { get; set; }

        public virtual ICollection<Bitacora> Bitacoras { get; set; }
    }
}
