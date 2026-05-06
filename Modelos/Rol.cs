using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class Rol
    {
        // Atributos privados
        private int _idRol;
        private string _nombreRol;
        private string _descripcionRol;

        // Constructor por defecto
        public Rol()
        {
        }

        // Constructor con parámetros
        public Rol(int idRol, string nombreRol, string descripcionRol)
        {
            IdRol = idRol;
            NombreRol = nombreRol;
            DescripcionRol = descripcionRol;
        }

        // Getters y Setters
        public int IdRol
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public string NombreRol
        {
            get { return _nombreRol; }
            set { _nombreRol = value; }
        }

        public string DescripcionRol
        {
            get { return _descripcionRol; }
            set { _descripcionRol = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"Rol: {_idRol}, Nombre: {_nombreRol}, " +
                   $"Descripción: {_descripcionRol}";
        }
    }
}
