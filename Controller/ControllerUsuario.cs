using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
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
    }
}
