﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Celular : Telefono
    {
        private int _CelularId;
        private String _Numero;

        public int TelefonoId { get; set; }

        public int CentralId { get; set; }

        public Central Central { get; set; }

        public LLamada Llamada { get; set; }

        public int _LlamadaId { get; set; }


        public Celular(String numero)
        {
            _Numero = numero;
           
        }

        public String Numero { get { return _Numero; } }
        public int CelularId { get { return _CelularId; } }

        public double Tarifa (int hora) 
        {
            if (hora >= 8 && hora <= 20)
                return 0.03;
            else
                return 0.01;

        }
    }
}
