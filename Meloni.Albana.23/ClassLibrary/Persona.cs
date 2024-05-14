using System.Text;

namespace ClassLibrary
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string barrioResidencia;
        protected DateTime nacimiento;

        public Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacimiento = nacimiento;
        }
        public Persona(string nombre, string apellido, DateTime nacimiento, string barrioResidencia)
            :this(nombre, apellido, nacimiento)
        {
            this.barrioResidencia = barrioResidencia;
        }

        public int Edad
        {
            get { return DateTime.Today.AddTicks(- nacimiento.Ticks).Year - 1; }
        }
        public string NombreCompleto
        {
            get { return $"{apellido}, {nombre}"; }
        }

        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(p.NombreCompleto);
            sb.AppendLine($"EDAD: {p.Edad}");
            sb.AppendLine(p.FichaExtra());

            return sb.ToString();
        }

        public override string ToString()
        {
            return NombreCompleto;
        }

        internal abstract string FichaExtra();
    }
}
