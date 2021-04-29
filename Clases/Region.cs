using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmpresa.Clases
{
    class Region
    {
        public string continente { get; set; }
        public string pais { get; set; }
        public string codigo { get; set; }

        public Region(string continente, string pais, string codigo)
        {
            this.continente = continente;
            this.pais = pais;
            this.codigo = codigo;
        }

        public Region() { }
        
    }
}
