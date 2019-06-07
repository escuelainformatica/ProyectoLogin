using ProyectoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLogin
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Usuario usr=new Usuario();
            usr=UsuarioServicio.Factory(txtUsuario,txtClave);
            bool esvalido=UsuarioServicio.Validar(usr);
            if (esvalido)
            {
                Response.Redirect("PantallaInicial.aspx");
            } else
            {
                Label1.Text="Usuario o clave incorrecto";
            }
        }
    }
}