using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagrama
{
    internal class ExAlumno : MiembroComunidad
    {
        public string curso;
        public ExAlumno() { }
        public ExAlumno(string curso) {
        this.curso = curso;
        }
        public ExAlumno(string id, string nombre, string apellido, int edad, string centroEducativo, string curso) : base(id, nombre, apellido, edad, centroEducativo)
        {
            this.curso = curso; 

        }
    }
}
