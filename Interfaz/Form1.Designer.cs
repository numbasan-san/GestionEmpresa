
namespace GestionEmpresa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Region = new System.Windows.Forms.Button();
            this.BTN_Departamento = new System.Windows.Forms.Button();
            this.BTN_Empleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(90, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ir a:";
            // 
            // BTN_Region
            // 
            this.BTN_Region.Location = new System.Drawing.Point(187, 131);
            this.BTN_Region.Name = "BTN_Region";
            this.BTN_Region.Size = new System.Drawing.Size(137, 48);
            this.BTN_Region.TabIndex = 0;
            this.BTN_Region.Text = "Región";
            this.BTN_Region.UseVisualStyleBackColor = true;
            this.BTN_Region.Click += new System.EventHandler(this.BTN_Region_Click);
            // 
            // BTN_Departamento
            // 
            this.BTN_Departamento.Location = new System.Drawing.Point(393, 131);
            this.BTN_Departamento.Name = "BTN_Departamento";
            this.BTN_Departamento.Size = new System.Drawing.Size(137, 48);
            this.BTN_Departamento.TabIndex = 2;
            this.BTN_Departamento.Text = "Departamento";
            this.BTN_Departamento.UseVisualStyleBackColor = true;
            this.BTN_Departamento.Click += new System.EventHandler(this.BTN_Departamento_Click);
            // 
            // BTN_Empleado
            // 
            this.BTN_Empleado.Location = new System.Drawing.Point(576, 131);
            this.BTN_Empleado.Name = "BTN_Empleado";
            this.BTN_Empleado.Size = new System.Drawing.Size(137, 48);
            this.BTN_Empleado.TabIndex = 3;
            this.BTN_Empleado.Text = "Empleado";
            this.BTN_Empleado.UseVisualStyleBackColor = true;
            this.BTN_Empleado.Click += new System.EventHandler(this.BTN_Empleado_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(927, 575);
            this.Controls.Add(this.BTN_Empleado);
            this.Controls.Add(this.BTN_Departamento);
            this.Controls.Add(this.BTN_Region);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Gestión Empresa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnDepartamento;
        private System.Windows.Forms.Button btnRegion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Region;
        private System.Windows.Forms.Button BTN_Departamento;
        private System.Windows.Forms.Button BTN_Empleado;
    }
}

