using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Celular : Telefono
    {
        private String _Numero;

        public Celular(String numero)
        {
            _Numero = numero;
        }

        public String Numero { get { return _Numero; } }

        public double Tarifa (int hora) 
        {
            if (hora >= 8 && hora <= 20)
                return 0.03;
            else
                return 0.01;

        }
    }
}
