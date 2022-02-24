using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClienteWEB
{
    public partial class Persona : System.Web.UI.Page
    {
        //Acceder al servicio web
        ServiceReference1.WSPersonaSoapClient servicio = new ServiceReference1.WSPersonaSoapClient();

        //Metodo para listar REGION
        private void Listar()
        {
            gvPersona.DataSource = servicio.Listar().Tables[0];
            gvPersona.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            //Solo  debe cargar la primera vez 
            if (!Page.IsPostBack)
                Listar();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //Solo  debe cargar la primera vez
            int DNI = int.Parse(txtId.Text.Trim());
            
            gvPersona.DataSource = servicio.Buscar(DNI).Tables[0];
            
            gvPersona.DataBind();
            if (servicio.Buscar(DNI).Tables[0].Rows.Count == 0)
            {
                Response.Write("<script>alert('ERROR: Persona no Encontrada, Intenta Nuevamente!!');</script>");
            }
            else
            {
               Response.Write("<script>alert('Se Encontro la Persona !!');</script>");
            }

        }
    }
}