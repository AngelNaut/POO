using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagrama
{
    internal abstract class MiembroComunidad
    {
        public string id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string centroEducativo { get; set; }

        public MiembroComunidad() { }

        public MiembroComunidad(string id, string nombre, string apellido, int edad, string centroEducativo) {
        this.id = id;
        this.nombre = nombre;  
        this.apellido = apellido;
        this.edad = edad;
        this.centroEducativo = centroEducativo;
        
        }

    }
}
