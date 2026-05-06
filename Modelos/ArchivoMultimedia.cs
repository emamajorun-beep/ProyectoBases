using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class ArchivoMultimedia
    {
        // Atributos privados
        private int _idAM;
        private string _nombreArchivo;
        private string _tipoArchivo;
        private string _rutaArchivo;
        private string _descripcion;
        private bool _principal;
        private int _idEquipo;

        // Constructor por defecto
        public ArchivoMultimedia()
        {
        }

        // Constructor con parámetros
        public ArchivoMultimedia(int idAM, string nombreArchivo, string tipoArchivo,
                                  string rutaArchivo, string descripcion,
                                  bool principal, int idEquipo)
        {
            IdAM = idAM;
            NombreArchivo = nombreArchivo;
            TipoArchivo = tipoArchivo;
            RutaArchivo = rutaArchivo;
            Descripcion = descripcion;
            Principal = principal;
            IdEquipo = idEquipo;
        }

        // Getters y Setters
        public int IdAM
        {
            get { return _idAM; }
            set { _idAM = value; }
        }

        public string NombreArchivo
        {
            get { return _nombreArchivo; }
            set { _nombreArchivo = value; }
        }

        public string TipoArchivo
        {
            get { return _tipoArchivo; }
            set { _tipoArchivo = value; }
        }

        public string RutaArchivo
        {
            get { return _rutaArchivo; }
            set { _rutaArchivo = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public bool Principal
        {
            get { return _principal; }
            set { _principal = value; }
        }

        public int IdEquipo
        {
            get { return _idEquipo; }
            set { _idEquipo = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"Archivo: {_nombreArchivo}, Tipo: {_tipoArchivo}, " +
                   $"Ruta: {_rutaArchivo}, Principal: {_principal}";
        }
    }
}
