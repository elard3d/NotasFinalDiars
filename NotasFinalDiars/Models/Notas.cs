using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasFinalDiars.Models
{
    public class Notas
    {
        public int idNota { get; set; }
        public string tituloNota { get; set; }
        public DateTime fechaModicacion { get; set; }
        public string contenidoNota { get; set; }
    }
}
