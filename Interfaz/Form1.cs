using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEmpresa.Interfaz;

namespace GestionEmpresa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { /*Accidente*/}

        private void btnRegion_Click(object sender, EventArgs e)
        {/*Accidente*/}

        private void button2_Click(object sender, EventArgs e)
        {/*Accidente*/}

        private void BTN_Region_Click(object sender, EventArgs e)
        {
            Interfaz.Region Show = new Interfaz.Region();
            Show.Visible = true;
        }

        private void BTN_Departamento_Click(object sender, EventArgs e)
        {
            Interfaz.Departamento Show = new Interfaz.Departamento();
            Show.Visible = true;
        }

        private void BTN_Empleado_Click(object sender, EventArgs e)
        {
            Interfaz.Empleado Show = new Interfaz.Empleado();
            Show.Visible = true;
        }
    }
}
