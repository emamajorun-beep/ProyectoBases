using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Proyecto1.Controller
{
    public class ControllerUsuario
    {
        internal bool InsertUsuario(Usuario objUsuario)
        {
            bool resultado = false;

            string sql = $"INSERT INTO `pr1 ex`.`usuarios` (codigoE, nombre1Usuario, apellido1Usuario, correoUsuario, telefonoE, programa, idRolFK) " +
    $"VALUES ('{objUsuario.CodigoE}', '{objUsuario.Nombre1Usuario}', '{objUsuario.Apellido1Usuario}', " +
    $"'{objUsuario.CorreoUsuario}', '{objUsuario.TelefonoE}', '{objUsuario.Programa}', {objUsuario.IdRolFK})";

            ConnectionBD objConnectionBD = new ConnectionBD();
            resultado = objConnectionBD.ExecuteQuery(sql);

            return resultado;
        }
        internal Usuario GetUsuarioById(int idUsuario)
        {
            Usuario objUsuario = null;
            string sql = $"SELECT * FROM `pr1 ex`.`usuarios` WHERE idUsuario = {idUsuario}";

            ConnectionBD objConnectionBD = new ConnectionBD();
            DataTable dt = objConnectionBD.ExecuteQuerySelect(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                objUsuario = new Usuario(
                    row["codigoE"].ToString(),
                    row["nombre1Usuario"].ToString(),
                    row["apellido1Usuario"].ToString(),
                    row["correoUsuario"].ToString(),
                    row["telefonoE"].ToString(),
                    row["programa"].ToString(),
                    Convert.ToInt32(row["idRolFK"])
                );
                objUsuario.IdUsuario = Convert.ToInt32(row["idUsuario"]);
            }

            return objUsuario;
        }   

        internal bool DeleteUsuario(int idUsuario)
        {
            string sql = $"DELETE FROM `pr1 ex`.`usuarios` WHERE idUsuario = {idUsuario}";
            ConnectionBD objConnectionBD = new ConnectionBD();
            return objConnectionBD.ExecuteQuery(sql);
        }


        internal bool UpdateUsuario(int idUsuario, Usuario objUsuario)
        {
            string sql = $"UPDATE `pr1 ex`.`usuarios` SET " +
                $"codigoE = '{objUsuario.CodigoE}', " +
                $"nombre1Usuario = '{objUsuario.Nombre1Usuario}', " +
                $"apellido1Usuario = '{objUsuario.Apellido1Usuario}', " +
                $"correoUsuario = '{objUsuario.CorreoUsuario}', " +
                $"telefonoE = '{objUsuario.TelefonoE}', " +
                $"programa = '{objUsuario.Programa}', " +
                $"idRolFK = {objUsuario.IdRolFK} " +
                $"WHERE idUsuario = {idUsuario}";
            ConnectionBD objConnectionBD = new ConnectionBD();
            return objConnectionBD.ExecuteQuery(sql);
        }
    }
}
