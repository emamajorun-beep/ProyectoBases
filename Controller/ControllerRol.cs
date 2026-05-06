using Proyecto1.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto1.Controller
{
    public class ControllerRol
    {
        internal List<Rol>? GetRoles()
        {
            List<Rol> _Listroles = null;
            string _sql = "SELECT * FROM `pr1 ex`.roles";
            Rol objRol = new Rol();
            _Listroles = objRol.GetRoles(_sql);

            return _Listroles;
        }
    }
}
