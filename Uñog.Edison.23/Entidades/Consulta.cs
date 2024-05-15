using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        public DateTime Fecha { get; }
        public Paciente Paciente { get; }

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
        }

        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($" *Fecha: {fecha}");

            return sb.ToString();
        }


    }
}
