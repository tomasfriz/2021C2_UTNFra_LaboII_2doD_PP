using System;

namespace Entidades
{
    public class Cliente
    {
        int dni;
        string nombre;
        string apellido;
        int edad;

        public Cliente(int dni, string nombre, string apellido, int edad)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
    }
}
