using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEmpleado
{
    class Empleado
    {
        // Atributos
        string nombres;
        string apellidos;
        string sexo;
        string fechaDeNacimiento;
        string fechaDeIngreso;
        float salario;
                 

        // Constructor Vacio
        public void Empleado()
        {
        
        }

        // Contructor Con Parametros
        public Empleado(string nombres, string apellidos, string sexo, string fechaDeNacimiento, string fechaDeIngreso, float salario)
        {
            this.nombres = Nombres;
            this.apellidos = Apellidos;
            this.sexo = Sexo;
            this.fechaDeNacimiento = FechaDeNacimiento ;
            this.fechaDeIngreso = FechaDeIngreso;
            this.salario = salario;
        
        }

        // Metods Get Y Set
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string FechaDeNacimiento
        {
            get { return fechaDeNacimiento; }
            set { fechaDeNacimiento = value; }
        }

        public string FechaDeIngreso
        {
            get { return fechaDeIngreso; }
            set { fechaDeIngreso = value; }
        }

        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        
    }


}
