using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class Usuario
    {
        // Atributos privados
        private int _idUsuario;
        private string _codigoE;
        private string _nombre1Usuario;
        private string _nombre2Usuario;
        private string _apellido1Usuario;
        private string _apellido2Usuario;
        private string _correoUsuario;
        private string _telefonoE;
        private string _programa;
        private bool _activoU;
        private int _idRolFK;

        // Constructor por defecto
        public Usuario()
        {
        }
        public Usuario(string codigoE, string nombre1Usuario,
                      string apellido1Usuario,
                      string correoUsuario, string telefonoE,
                      string programa, int idRolFK)
        {
            CodigoE = codigoE;
            Nombre1Usuario = nombre1Usuario;
            Apellido1Usuario = apellido1Usuario;
            CorreoUsuario = correoUsuario;
            TelefonoE = telefonoE;
            Programa = programa;
            IdRolFK = idRolFK;
        }

        // Constructor con parámetros (sin idUsuario porque es AI)
        public Usuario(string codigoE, string nombre1Usuario, string nombre2Usuario,
                       string apellido1Usuario, string apellido2Usuario,
                       string correoUsuario, string telefonoE,
                       string programa, bool activoU, int idRolFK)
        {
            CodigoE = codigoE;
            Nombre1Usuario = nombre1Usuario;
            Nombre2Usuario = nombre2Usuario;
            Apellido1Usuario = apellido1Usuario;
            Apellido2Usuario = apellido2Usuario;
            CorreoUsuario = correoUsuario;
            TelefonoE = telefonoE;
            Programa = programa;
            ActivoU = activoU;
            IdRolFK = idRolFK;
        }

        // Getters y Setters
        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public string CodigoE
        {
            get { return _codigoE; }
            set { _codigoE = value; }
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

        public string TelefonoE
        {
            get { return _telefonoE; }
            set { _telefonoE = value; }
        }

        public string Programa
        {
            get { return _programa; }
            set { _programa = value; }
        }

        public bool ActivoU
        {
            get { return _activoU; }
            set { _activoU = value; }
        }

        public int IdRolFK
        {
            get { return _idRolFK; }
            set { _idRolFK = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"Usuario: {_idUsuario}, Código: {_codigoE}, " +
                   $"Nombre: {_nombre1Usuario} {_apellido1Usuario}, " +
                   $"Correo: {_correoUsuario}, Programa: {_programa}";
        }
    }
}