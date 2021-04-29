using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.Clases
{
    class Departamento
    {

        public int codigo { get; set; }
        public string nombre { get; set; }
        public int paisId { get; set; }
        public int noContact { get; set; }

        public Departamento(int codigo, string nombre, int paisId, int noContact)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.paisId = paisId;
            this.noContact = noContact;
        }

        public Departamento() { }

    }
}
