using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.Clases
{
    class Departamento
    {

        public string nombre { get; set; }
        public string paisId { get; set; }
        public string codigo { get; set; }
        public string noContact { get; set; }

        public Departamento(string nombre, string paisId, string codigo, string noContact)
        {
            this.nombre = nombre;
            this.paisId = paisId;
            this.codigo = codigo;
            this.noContact = noContact;
        }

        public Departamento() { }

    }
}
