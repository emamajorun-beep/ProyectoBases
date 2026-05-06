using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class CategoriaEquipo
    {
        // Atributos privados
        private int _idCE;
        private string _nombreCategoria;
        private string _descripcionCategoria;

        // Constructor por defecto
        public CategoriaEquipo()
        {
        }

        // Constructor con parámetros
        public CategoriaEquipo(int idCE, string nombreCategoria, string descripcionCategoria)
        {
            IdCE = idCE;
            NombreCategoria = nombreCategoria;
            DescripcionCategoria = descripcionCategoria;
        }

        // Getters y Setters
        public int IdCE
        {
            get { return _idCE; }
            set { _idCE = value; }
        }

        public string NombreCategoria
        {
            get { return _nombreCategoria; }
            set { _nombreCategoria = value; }
        }

        public string DescripcionCategoria
        {
            get { return _descripcionCategoria; }
            set { _descripcionCategoria = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"Categoría: {_idCE}, Nombre: {_nombreCategoria}, " +
                   $"Descripción: {_descripcionCategoria}";
        }
    }
}
