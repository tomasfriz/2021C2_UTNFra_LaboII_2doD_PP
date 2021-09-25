using System;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private string nombre;
        private string apellido;
        private int edad;
        private string equipo;
        private Periferico periferico;
        private Hardware hardware;
        private Software software;
        private Juego juego;
        private Tipo tipo;
        private Marcas marca;

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
        public Cliente(int dni, string nombre, string apellido, int edad, string equipo) : this(dni, nombre, apellido, edad)
        {
            this.equipo = equipo;
        }

        public Cliente(int dni, string nombre, string apellido, int edad, string equipo, Periferico periferico, Hardware hardware, Software software, Juego juego) : this(dni, nombre, apellido, edad, equipo)
        {
            this.periferico = periferico;
            this.hardware = hardware;
            this.software = software;
            this.juego = juego;
        }

        public Cliente(int dni, string nombre, string apellido, int edad, string equipo,Tipo tipo, Marcas marca) : this(dni, nombre, apellido, edad, equipo)
        {
            this.tipo = tipo;
            this.marca = marca;
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
        public string Equipo
        {
            get
            {
                return equipo;
            }
            set
            {
                equipo = value;
            }
        }
        public Periferico Periferico
        {
            get
            {
                return periferico;
            }
        }
        public Hardware Hardware
        {
            get
            {
                return hardware;
            }
        }
        public Software Software
        {
            get
            {
                return software;
            }
        }
        public Juego Juego
        {
            get
            {
                return juego;
            }
        }

        public Tipo Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                tipo = value;
            }
        }
        public Marcas Marca 
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
    }
}
