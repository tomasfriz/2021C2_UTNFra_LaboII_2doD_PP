using System;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;

        public Cliente()
        {
        }
        public Cliente(int dni, string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public int Dni
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }
        public string Nombre 
        { 
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido 
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        public int Edad 
        {
            get 
            { 
                return edad; 
            }
            set 
            { 
                edad = value; 
            }
        }
    }
}
