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
    class ctrlEmpleado
    {

        suportEmpleado empleado;
        clsEmpleado recipiente;
        Empleado vista;

        public ctrlEmpleado(Empleado vista)
        {
            this.vista = vista;
            vista.Load += new EventHandler(cargarData);
            vista.btnAgregar.Click += new EventHandler(agregar);
            vista.btnEliminar.Click += new EventHandler(eliminar);
            vista.btnModificar.Click += new EventHandler(modificar);
            empleado = new suportEmpleado();
            recipiente = new clsEmpleado();
        }

        private void cargarData(object sender, EventArgs e)
        {
            vista.dataGridView1.DataSource = empleado.verRegistro();
            vista.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void agregar(object sender, EventArgs e)
        {
            recipiente.nombre = vista.txtNombre.Text;
            recipiente.apellido = vista.txtApellido.Text;
            recipiente.cargo = vista.txtEmpleo.Text;
            recipiente.departId = int.Parse(vista.txtDepartID.Text);
            empleado.agregar(recipiente);
            vista.dataGridView1.DataSource = empleado.verRegistro();
            MessageBox.Show("Empleado Agregado.");
        }

        private void eliminar(object sender, EventArgs e)
        {
            recipiente.id = int.Parse(vista.txtID.Text);
            empleado.eliminar(recipiente);
            vista.dataGridView1.DataSource = empleado.verRegistro();
            MessageBox.Show("Empleado Eliminado.");
        }

        private void modificar(object sender, EventArgs e)
        {
            recipiente.id = int.Parse(vista.txtID.Text);
            recipiente.nombre = vista.txtNombre.Text;
            recipiente.apellido = vista.txtApellido.Text;
            recipiente.cargo = vista.txtEmpleo.Text;
            recipiente.departId = int.Parse(vista.txtDepartID.Text);
            empleado.modificar(recipiente);
            vista.dataGridView1.DataSource = empleado.verRegistro();
            MessageBox.Show("Empleado Modificado.");
        }

    }
}
