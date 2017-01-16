using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Fijo : Telefono
    {

        public int TelefonoId { get; set; }

        public int CentralId { get; set; }

        public Central Central { get; set; }

        public LLamada Llamada { get; set; }

        public int _LlamadaId { get; set; }

        private int _FijoId;
        private String _Numero;

        public Fijo(String numero)
        {
            _Numero = numero;
        }

        public int FijoId { get { return _FijoId; } }
        public String Numero { get { return _Numero; } }

        public double Tarifa(int hora)
        {
           return 0.04;

        }
    }
}
