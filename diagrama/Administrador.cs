using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagrama
{
    internal class Administrador : Docente
    {
       public Administrador() { }
        public Administrador(string id, string nombre, string apellido, int edad, string centroEducativo, double sueldo, string horarioTrabajo, string numeroIdentidad, string area, string cargo) : base(id, nombre, apellido, edad, centroEducativo, sueldo, horarioTrabajo, numeroIdentidad, area, cargo)
        {
        }

       
    }
}
