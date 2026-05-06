using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Modelos
{
    public class DetalleSolicitud
    {
        // Atributos privados
        private int _idDS;
        private int _idSP;
        private int _idEquipo;
        private string _observacionDetalle;

        // Constructor por defecto
        public DetalleSolicitud()
        {
        }

        // Constructor con parámetros
        public DetalleSolicitud(int idDS, int idSP, int idEquipo, string observacionDetalle)
        {
            IdDS = idDS;
            IdSP = idSP;
            IdEquipo = idEquipo;
            ObservacionDetalle = observacionDetalle;
        }

        // Getters y Setters
        public int IdDS
        {
            get { return _idDS; }
            set { _idDS = value; }
        }

        public int IdSP
        {
            get { return _idSP; }
            set { _idSP = value; }
        }

        public int IdEquipo
        {
            get { return _idEquipo; }
            set { _idEquipo = value; }
        }

        public string ObservacionDetalle
        {
            get { return _observacionDetalle; }
            set { _observacionDetalle = value; }
        }

        // ToString
        public override string ToString()
        {
            return $"DetalleSolicitud: {_idDS}, Solicitud: {_idSP}, " +
                   $"Equipo: {_idEquipo}, Observación: {_observacionDetalle}";
        }
    }
}
