using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class LLamada
    {
        private Telefono _Telefono;
        private Reloj _Reloj;

        public LLamada(String numero)
        {
            if (numero[0] == '9')
                _Telefono = new Celular(numero);
            else
                _Telefono = new Fijo(numero);

            _Reloj = new Reloj();
        }

        public Telefono Telefono { get { return _Telefono; } }
        public Reloj Reloj { get { return _Reloj; } }

        public double Tarifa()
        {
            return _Telefono.Tarifa(DateTime.Now.Hour);
        }
    }
}
