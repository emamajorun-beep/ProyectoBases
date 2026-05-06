using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class EstadoEquipo
    {
        // Atributos privados
        private int _idEE;
        private string _nombreEstado;
        private string _descripcionEstado;

        // Constructor por defecto
        public EstadoEquipo()
        {
        }

        // Constructor con parámetros
        public EstadoEquipo(int idEE, string nombreEstado, string descripcionEstado)
        {
            IdEE = idEE;
            NombreEstado = nombreEstado;
            DescripcionEstado = descripcionEstado;
        }

        // Getters y Setters
        public int IdEE
        {
            get { return _idEE; }
            set { _idEE = value; }
        }

        public string NombreEstado
        {
            get { return _nombreEstado; }
            set { _nombreEstado = value; }
        }

        public string DescripcionEstado
        {
            get { return _descripcionEstado; }
            set { _descripcionEstado = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"EstadoEquipo: {_idEE}, Nombre: {_nombreEstado}, " +
                   $"Descripción: {_descripcionEstado}";
        }
    }
}
