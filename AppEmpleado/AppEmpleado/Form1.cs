using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEmpleado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string FechaDeNacimiento = dtpFechaDeNacimiento.Value.ToString("dd/MM/yyyy");
            string FechaDeIngreso    = dtpFechaDeIngreso.Value.ToString("dd/MM/yyyy");
            Empleado empleado1 = new Empleado(txtNombre.Text, txtApellido.Text, cmbSexo.SelectedItem.ToString(), 
                                 FechaDeNacimiento, FechaDeIngreso, float.Parse(txtSalario.Text));


            MessageBox.Show(" El Empleado: " + empleado1.Nombres + " " + empleado1.Apellidos + " " + empleado1.Sexo + " "
                            + empleado1.FechaDeNacimiento + " " + empleado1.FechaDeIngreso+" "+empleado1.Salario+" Ha Sido Registrado. ");
        }
    }
}
