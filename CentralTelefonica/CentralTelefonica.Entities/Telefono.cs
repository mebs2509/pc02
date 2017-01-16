using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{

   public interface Telefono
    {
        int TelefonoId { get; set; }

        int CentralId { get; set; }

        Central Central { get; set; }

        LLamada Llamada { get; set; }

        int _LlamadaId { get; set; }

        String Numero { get; }

        double Tarifa(int hora);

    }
}
