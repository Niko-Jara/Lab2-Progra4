using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Lab2Progra

{
    delegate double metmat(double num1);

    public partial class Principal : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            nomUsuario.InnerHtml = ((Usuario)Session["objuser"]).user;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            metmat fnmult = Operac.multip;
            double num1 = Convert.ToDouble(TextBox1.Text);
            double Resultado = fnmult(num1);
            TextBox2.Text = Resultado.ToString();

            Action<string> fn2 = Operac.escribirBitacora;
            string guardar = String.Format("Se multiplica el numero {0} por 2 y da como resultado: {1}", num1, Resultado);
            fn2(guardar);

        }


    }

}