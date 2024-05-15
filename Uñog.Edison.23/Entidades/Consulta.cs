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

        //public Paciente Paciente 
        //{
        //    get { return paciente.NombreApellido; }
        //}

        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.paciente = paciente;
            this.fecha = fecha;
        }


        public override string ToString()
        {
            StringBuilder sb = new();

            sb.AppendLine($" *Fecha: {fecha}");
            //sb.AppendLine($" *Paciente: {paciente.ToString()}");

            return sb.ToString();
        }
        //public static string ToString(Paciente p)
        //{
        //    StringBuilder sb = new();

        //    sb.AppendLine($" *Se va atender a: {p.NombreApellido}");



        //    return sb.ToString();
        //}


    }
}
