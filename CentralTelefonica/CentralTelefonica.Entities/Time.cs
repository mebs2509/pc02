using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica.Entities
{
    public class Time
    {
        DateTime _HoraActual;

        public Time()
        {
            _HoraActual = DateTime.Now;
        }

        public void GetTime(out int horas, out int minutos, out int segundos)
        {
            horas = _HoraActual.Hour;
            minutos = _HoraActual.Minute;
            segundos = _HoraActual.Second;

          
        }
    }
}
