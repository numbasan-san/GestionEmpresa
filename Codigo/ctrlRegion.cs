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
    class ctrlRegion
    {
        
        suportRegion region;
        clsRegion recipiente;
        Region vista;

        public ctrlRegion (Region vista)
        {
            this.vista = vista;
            vista.Load += new EventHandler(cargarData);
            vista.btnAgregar.Click += new EventHandler(agregar);
            vista.btnEliminar.Click += new EventHandler(eliminar);
            vista.btnModificar.Click += new EventHandler(modificar);
            region = new suportRegion();
            recipiente = new clsRegion();
        }

        private void cargarData(object sender, EventArgs e)
        {
            vista.dataGridView1.DataSource = region.verRegistro();
            vista.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        
        private void agregar(object sender, EventArgs e)
        {
            recipiente.continente = vista.txtPais.Text;
            recipiente.pais = vista.txtPais.Text;
            region.agregar(recipiente);
            vista.dataGridView1.DataSource = region.verRegistro();
            MessageBox.Show("Región Agregada.");
        }
        
        private void eliminar(object sender, EventArgs e)
        {
            recipiente.codigo = int.Parse(vista.txtCodigo.Text);
            region.eliminar(recipiente);
            vista.dataGridView1.DataSource = region.verRegistro();
            MessageBox.Show("Región Eliminada.");
        }

        private void modificar(object sender, EventArgs e)
        {
            recipiente.codigo = int.Parse(vista.txtCodigo.Text);
            recipiente.continente = vista.txtContinente.Text;
            recipiente.pais = vista.txtPais.Text;
            region.modificar(recipiente);
            vista.dataGridView1.DataSource = region.verRegistro();
            MessageBox.Show("Región Modificada.");
        }


    }
}
