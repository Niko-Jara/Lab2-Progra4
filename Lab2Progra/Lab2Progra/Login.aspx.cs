using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab2Progra
{
    public partial class Login : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario objuser = new Usuario();
            objuser.user = txtUsuario.Text;
            objuser.contrase = txtUsuario.Text;
            Session["objuser"] = objuser;
        }

        protected void Btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Principal.aspx");
        }

    }
}