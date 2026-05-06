using MySql.Data.MySqlClient;
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

        public List<Rol> GetRoles(string sql)
        {
           List<Rol> _Listroles = null;
           ConnectionBD objConnectionBD = new ConnectionBD();

            using( var conn = objConnectionBD.DataSource())
            {
                
                conn.Open();
                    objConnectionBD.ConnectOpened();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {   
                    _Listroles = new List<Rol>();
                    while (reader.Read())
                    { 
                        {
                            
                            int idr = reader.GetInt32(0);
                            string namer = reader.GetString(1);
                            string desr = reader.GetString(2);
                            Rol rol = new Rol(idr, namer, desr);
                            _Listroles.Add(rol);
                        }
                       
                    }
                }            
            }

            return _Listroles;
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
