using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace API_Amigos.Models.ADO.Contexto
{

    public class AdoContexto
    {
        public string PegaStringConexao()
        {
            SqlDataSource sql = new SqlDataSource();
            sql.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoBanco"].ConnectionString;

            return sql.ConnectionString;
        }
    }
}