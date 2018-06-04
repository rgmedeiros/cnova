using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using API_Amigos.Models.ADO.Contexto;

namespace API_Amigos.Models.ADO.Log
{

    public class LogAdo
    {
        private AdoContexto _ado = new AdoContexto();

        public bool IncluiLog(string NomePesq, double LatitudePesq, double LongitudePesq,
                              string NomeProximo, double LatitudeProximo, double LongitudePromixo)
        {
            var constr = _ado.PegaStringConexao();

            SqlConnection _conn = new SqlConnection(constr);
            _conn.Open();

            using (SqlCommand command = new SqlCommand("IncluiLogProc", _conn))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@NomePesq", NomePesq);
                command.Parameters.AddWithValue("@LatitudePesq", LatitudePesq);
                command.Parameters.AddWithValue("@LongitudePesq", LongitudePesq);
                command.Parameters.AddWithValue("@NomeProximo", NomeProximo);
                command.Parameters.AddWithValue("@LatitudeProximo", LatitudeProximo);
                command.Parameters.AddWithValue("@LongitudePromixo", LongitudePromixo);

                command.ExecuteNonQuery();

            }

            return true;
        }

    }
}