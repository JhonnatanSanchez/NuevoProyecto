using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuevoProyecto
{
    class Persona
    {
        private String nombre;
        private String cedula;
        private int edad;
        private int anioNacimiento;

        public int calcularEdad()
        {
            edad = 2021 - anioNacimiento;
            return this.edad;
        }

        public Persona(string nombre, string cedula, int anioNacimiento)
        {
            this.nombre = nombre;
            this.cedula = cedula;
            this.anioNacimiento = anioNacimiento;

        }
    }
}
