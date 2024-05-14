using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PersonalMedico : Persona
    {
        List<Consulta> consultas;
        bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime nacimiento, bool esResidente)
            :base(nombre, apellido, nacimiento)
        {
            this.esResidente = esResidente;
            consultas = new List<Consulta>();
        }

        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta = new Consulta(DateTime.Now, paciente);
            doctor.consultas.Add(consulta);

            return consulta;
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("¿Finalizó residencia? ");
            if (esResidente)
            {
                sb.AppendLine("SI");
            } else {
                sb.AppendLine("NO");
            }

            if (consultas is not null)
            {
                sb.AppendLine();
                sb.AppendLine("ATENCIONES:");
                foreach (Consulta item in consultas)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString();
        }
    }
}
