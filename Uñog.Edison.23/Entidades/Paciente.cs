using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        private string diagnostico;

        public string Diagnostico
        {
            get { return diagnostico; }
            set { this.diagnostico = value; }
        }

        public Paciente(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia) 
            : base(nombre, apellido, nacimiento, barrioRecidencia)
        {
        }

        public override string FichaExtra()
        {
            StringBuilder sb = new();

            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine($" *Recide: {barrioRecidencia}");
            sb.AppendLine($" *Diagnosstico: {diagnostico}");

            return sb.ToString();
        }
    }
}
