
using ProyectoLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoLogin
{
    public partial class WebImagenes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Usuario miusuario=new Usuario();
            //miusuario.Login="john";


            
            List<Usuario> usuarios=new List<Usuario>();
            Usuario usr=new Usuario();
            usr.Login="John";
            usr.Clave="12345";
            usuarios.Add(usr);

            usr = new Usuario();
            usr.Login = "Anna";
            usr.Clave = "99999";
            usuarios.Add(usr);
          
            DropDownList1.DataSource=usuarios;
            DropDownList1.DataBind();
            GridView1.DataSource=usuarios;
            GridView1.DataBind();
            BulletedList1.DataSource=usuarios;
            BulletedList1.DataBind();

        }
    }
}