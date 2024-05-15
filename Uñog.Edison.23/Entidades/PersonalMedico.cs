using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;
        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente)
            : base(nombre, apellido, nacimiento)
        {
            consultas = new List<Consulta>();
            this.esResidente = esResidente;
        }

        public override string FichaExtra()
        {
            string Residente = esResidente ? "SI" : "NO";
            StringBuilder sb = new();

            sb.AppendLine($" *{base.ToString()}");
            sb.AppendLine($" *Finalizo residencia?: {Residente}");
            sb.AppendLine($" *Edad: {Edad}");

            return sb.ToString();
        }

        public static bool operator +(PersonalMedico doctor, Paciente paciente)
        {
            DateTime fechaActual = DateTime.Today;
            if (doctor != null && paciente != null)
            {
                doctor.consultas.Add(new Consulta(fechaActual, paciente));
                return true;
            }
            return false;
        }

    }
}
