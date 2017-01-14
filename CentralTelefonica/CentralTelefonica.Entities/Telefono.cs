using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public interface Telefono
    {
        String Numero { get; }

        double Tarifa(int hora);
    }
}
