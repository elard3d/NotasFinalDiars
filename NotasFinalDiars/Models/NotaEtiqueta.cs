using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotasFinalDiars.Models
{
    public class NotaEtiqueta
    {
        public int idEtiquetaNota { get; set; }
        public int idNota { get; set; }
        public int idEtiqueta { get; set; }

        public Notas notas { get; set; }
        public Etiquetas etiquetas { get; set; }
    }
}
