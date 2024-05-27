using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagrama
{
    internal class Estudiante : MiembroComunidad
    {
        public string curso { get; set; }
        public Estudiante() { }
        public Estudiante(string id, string nombre, string apellido, int edad, string centroEducativo) : base(id, nombre, apellido, edad, centroEducativo)
        {
        }
    }
}
