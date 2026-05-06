using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class SolicitudPrestamo
    {
        // Atributos privados
        private int _idSE;
        private string _fechaSolicitud;
        private string _fechaInicio;
        private string _fechaFin;
        private string _estadoSolicitud;
        private string _observacion;
        private int _idUsuario;

        // Constructor por defecto
        public SolicitudPrestamo()
        {
        }

        // Constructor con parámetros
        public SolicitudPrestamo(int idSE, string fechaSolicitud, string fechaInicio,
                                  string fechaFin, string estadoSolicitud,
                                  string observacion, int idUsuario)
        {
            IdSE = idSE;
            FechaSolicitud = fechaSolicitud;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            EstadoSolicitud = estadoSolicitud;
            Observacion = observacion;
            IdUsuario = idUsuario;
        }

        // Getters y Setters
        public int IdSE
        {
            get { return _idSE; }
            set { _idSE = value; }
        }

        public string FechaSolicitud
        {
            get { return _fechaSolicitud; }
            set { _fechaSolicitud = value; }
        }

        public string FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }

        public string FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }

        public string EstadoSolicitud
        {
            get { return _estadoSolicitud; }
            set { _estadoSolicitud = value; }
        }

        public string Observacion
        {
            get { return _observacion; }
            set { _observacion = value; }
        }

        public int IdUsuario
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"SolicitudPrestamo: {_idSE}, Estado: {_estadoSolicitud}, " +
                   $"Inicio: {_fechaInicio}, Fin: {_fechaFin}, " +
                   $"Usuario: {_idUsuario}";
        }
    }
}
