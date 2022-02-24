using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace ServicioReniecs
{
    /// <summary>
    /// Descripción breve de WSPersona
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSPersona : System.Web.Services.WebService
    {
        //Traer la cade de conexion desde el archivo seguro web.confg
        private static string cadena = ConfigurationManager.ConnectionStrings["Cadena"].ConnectionString;
        private static SqlConnection conexion = new SqlConnection(cadena);

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod(Description = "Listar los datos de la tabla Region")]
        public DataSet Listar()
        {
            string consulta = "select *from Persona";
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return (data);
        }
        [WebMethod(Description = "Buscar en la tabla Persona Por DNI")]
        public DataSet Buscar(int criterio)
        {
            string consulta = String.Empty;
            consulta = "select *from Persona where DNI ='" + criterio + "'";
            SqlCommand command = new SqlCommand(consulta, conexion);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }
    }
}
