using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.Clases
{
    class Empleado
    {

        public string nombre { get; set; }
        public string apellido { get; set; }
        public string departId { get; set; }
        public string empleo { get; set; }
        public string email { get; set; }

        public Empleado (string nombre, string apellido, string departId, string empleo, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.departId = departId;
            this.empleo = empleo;
            this.email = email;
        }

        public Empleado(){}

    }
}
