using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected string barrioRecidencia;
        protected DateTime nacimiento;
        protected string nombre;

        public int Edad
        {
            get
            {  
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        public string NombreApellido
        {
            get
            {
                return $"{nombre} {apellido}";
            }
        }

        public Persona(string nombre, string apellido, DateTime nacimiento) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }

        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioRecidencia)
            : this(nombre, apellido, nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
            this.barrioRecidencia = barrioRecidencia;
        }

        public abstract string FichaExtra();

        public static string FichaPerssona(Persona p)
        {
            StringBuilder sb = new();

            sb.AppendLine($" *Apellido y Nombre: {p.NombreApellido}");
            sb.AppendLine($" *Edad: {p.Edad}");
            sb.AppendLine($" *Barrio: {p.barrioRecidencia}");
            sb.AppendLine($" *Fecha Nacimiento: {p.nacimiento}");

            return sb.ToString();
        }

        public override string ToString()
        {
            return nombre + apellido;
        }

    }
}
