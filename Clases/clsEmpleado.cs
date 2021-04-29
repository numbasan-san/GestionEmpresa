using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.Clases
{
    class clsEmpleado
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int departId { get; set; }
        public string cargo { get; set; }

        public clsEmpleado (int id, string nombre, string apellido, int departId,  string cargo )
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.departId = departId;
            this.cargo = cargo;
        }

        public clsEmpleado(){}

    }
}
