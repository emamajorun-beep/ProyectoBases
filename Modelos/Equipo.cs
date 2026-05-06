using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class Equipo
    {
        // Atributos privados
        private int _idEquipo;
        private string _codigoInterno;
        private string _nombreEquipo;
        private string _marcaEquipo;
        private string _modeloEquipo;
        private string _fechaCompra;
        private bool _activo;
        private int _idCE;
        private int _idEE;

        // Constructor por defecto
        public Equipo()
        {
        }

        // Constructor con parámetros
        public Equipo(int idEquipo, string codigoInterno, string nombreEquipo,
                      string marcaEquipo, string modeloEquipo, string fechaCompra,
                      bool activo, int idCE, int idEE)
        {
            IdEquipo = idEquipo;
            CodigoInterno = codigoInterno;
            NombreEquipo = nombreEquipo;
            MarcaEquipo = marcaEquipo;
            ModeloEquipo = modeloEquipo;
            FechaCompra = fechaCompra;
            Activo = activo;
            IdCE = idCE;
            IdEE = idEE;
        }

        // Getters y Setters
        public int IdEquipo
        {
            get { return _idEquipo; }
            set { _idEquipo = value; }
        }

        public string CodigoInterno
        {
            get { return _codigoInterno; }
            set { _codigoInterno = value; }
        }

        public string NombreEquipo
        {
            get { return _nombreEquipo; }
            set { _nombreEquipo = value; }
        }

        public string MarcaEquipo
        {
            get { return _marcaEquipo; }
            set { _marcaEquipo = value; }
        }

        public string ModeloEquipo
        {
            get { return _modeloEquipo; }
            set { _modeloEquipo = value; }
        }

        public string FechaCompra
        {
            get { return _fechaCompra; }
            set { _fechaCompra = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public int IdCE
        {
            get { return _idCE; }
            set { _idCE = value; }
        }

        public int IdEE
        {
            get { return _idEE; }
            set { _idEE = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"Equipo: {_idEquipo}, Nombre: {_nombreEquipo}, " +
                   $"Marca: {_marcaEquipo}, Modelo: {_modeloEquipo}, " +
                   $"Activo: {_activo}";
        }
    }
}
