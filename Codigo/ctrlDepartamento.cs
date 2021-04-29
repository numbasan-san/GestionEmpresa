using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEmpresa.Data;
using GestionEmpresa.Interfaz;
using System.Windows.Forms;
using GestionEmpresa.Clases;

namespace GestionEmpresa.Codigo
{
    class ctrlDepartamento
    {

        suportDepartamento depart;
        clsDepartamento recipiente;
        Departamento vista;

        public ctrlDepartamento(Departamento vista)
        {
            this.vista = vista;
            vista.Load += new EventHandler(cargarData);
            vista.btnAgregar.Click += new EventHandler(agregar);
            vista.btnEliminar.Click += new EventHandler(eliminar);
            vista.btnModificar.Click += new EventHandler(modificar);
            depart = new suportDepartamento();
            recipiente = new clsDepartamento();
        }

        private void cargarData(object sender, EventArgs e)
        {
            vista.dataGridView1.DataSource = depart.verRegistro();
            vista.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void agregar(object sender, EventArgs e)
        {
            recipiente.nombre = vista.txtNombre.Text;
            recipiente.noContact = int.Parse(vista.txtNoContacto.Text);
            recipiente.paisId = int.Parse(vista.txtIdPais.Text);
            depart.agregar(recipiente);
            vista.dataGridView1.DataSource = depart.verRegistro();
            MessageBox.Show("Departamento Agregado.");
        }

        private void eliminar(object sender, EventArgs e)
        {
            recipiente.codigo = int.Parse(vista.txtCodigo.Text);
            depart.eliminar(recipiente);
            vista.dataGridView1.DataSource = depart.verRegistro();
            MessageBox.Show("Departamento Eliminado.");
        }

        private void modificar(object sender, EventArgs e)
        {
            recipiente.codigo = int.Parse(vista.txtCodigo.Text);
            recipiente.nombre = vista.txtNombre.Text;
            recipiente.noContact = int.Parse(vista.txtNoContacto.Text);
            recipiente.paisId = int.Parse(vista.txtIdPais.Text);
            depart.modificar(recipiente);
            vista.dataGridView1.DataSource = depart.verRegistro();
            MessageBox.Show("Departamento Modificado.");
        }

    }
}
