using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diagrama
{
    internal abstract class Empleado : MiembroComunidad { 


    public double sueldo { get; set; }
    public string horarioTrabajo { get; set; }
    public string numeroIdentidad { get; set; }
    public string area { get; set; }
    public string cargo { get; set; }

    protected Empleado() { }
    protected Empleado(string id, string nombre, string apellido, int edad, string centroEducativo, double sueldo, string horarioTrabajo, string numeroIdentidad, string area, string cargo) : base(id, nombre, apellido, edad, centroEducativo)
        {
            this.sueldo = sueldo;
            this.horarioTrabajo = horarioTrabajo;
            this.numeroIdentidad = numeroIdentidad;
            this.area = area;
            this.cargo = cargo;
        }

    

    }
}
