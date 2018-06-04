using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Amigos.Models.Entidades;
using API_Amigos.Models;

namespace API_Amigos.Controllers
{
    public class TokenController : ApiController
    {
        Token token = new Token();
        ITokenRepositorio repositorio = new TokenRepositorio();

        //public Token GetToken(string numToken)
        //{
        //    return repositorio.GetToken(numToken);
        //}

        public Token GetNumToken(int idToken)
        {
            return repositorio.GetNumToken(idToken);
        }

        public Token GetToken()
        {
            var idToken = RandomNumber(1, 14);

            return repositorio.GetNumToken(idToken);

        }

        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
