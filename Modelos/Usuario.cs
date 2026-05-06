using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class Usuario
    {
        // Atributos privados
        private int _idUsuario;
        private string _nombre1Usuario;
        private string _nombre2Usuario;
        private string _apellido1Usuario;
        private string _apellido2Usuario;
        private string _correoUsuario;
        private string _tipoUsuario;

        // Constructor por defecto
        public Usuario()
        {
        }

        // Constructor con parámetros
        public Usuario( string nombre1Usuario, string nombre2Usuario,
                       string apellido1Usuario, string apellido2Usuario,
                       string correoUsuario, string tipoUsuario)
        {
            
            Nombre1Usuario = nombre1Usuario;
            Nombre2Usuario = nombre2Usuario;
            Apellido1Usuario = apellido1Usuario;
            Apellido2Usuario = apellido2Usuario;
            CorreoUsuario = correoUsuario;
            TipoUsuario = tipoUsuario;
        }

        // Getters y Setters
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string Nombre1Usuario
        {
            get { return _nombre1Usuario; }
            set { _nombre1Usuario = value; }
        }

        public string Nombre2Usuario
        {
            get { return _nombre2Usuario; }
            set { _nombre2Usuario = value; }
        }

        public string Apellido1Usuario
        {
            get { return _apellido1Usuario; }
            set { _apellido1Usuario = value; }
        }

        public string Apellido2Usuario
        {
            get { return _apellido2Usuario; }
            set { _apellido2Usuario = value; }
        }

        public string CorreoUsuario
        {
            get { return _correoUsuario; }
            set { _correoUsuario = value; }
        }

        public string TipoUsuario
        {
            get { return _tipoUsuario; }
            set { _tipoUsuario = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"Usuario: {_idUsuario}, Nombre: {_nombre1Usuario} {_apellido1Usuario}, " +
                   $"Correo: {_correoUsuario}, Tipo: {_tipoUsuario}";
        }
    }
}
