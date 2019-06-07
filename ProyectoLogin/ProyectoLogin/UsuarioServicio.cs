using ProyectoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ProyectoLogin
{
    public class UsuarioServicio
    {
        public static Usuario Factory(TextBox txtUsuario,TextBox txtClave)
        {
            Usuario usr=new Usuario();
            usr.Login=txtUsuario.Text;
            usr.clave=txtClave.Text;
            return usr;
        }
        public static bool Validar(Usuario usr)
        {
            if (usr.Login=="admin" && usr.clave=="admin")
            {
                return true;
            }
            return false;
        }
    }
}