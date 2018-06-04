using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API_Amigos.Models;
using API_Amigos.Models.ADO.Log;
using API_Amigos.Models.Entidades;

namespace API_Amigos.Controllers
{
    public class AmigosController : ApiController
    {
        static readonly IAmigosRepositorio repositorio = new AmigosRepositorio();
        static readonly LogAdo log = new LogAdo();
        static readonly ITokenRepositorio repoToken = new TokenRepositorio();
        public Token token = new Token();

        public IEnumerable<Amigos> GetAllAmigos()
        {
            return repositorio.GetAllAmigos();
        }

        public IEnumerable<Amigos> GetAmigosProximos(int Id, string numToken)
        {
            double distanciaKM = 0;
            List<Amigos> amigos = new List<Amigos>();

            Amigos amigoSelecionado = repositorio.Get(Id);

            if (amigoSelecionado == null)
            {
                amigos.Add(new Amigos { ID = -1, Nome = "Amigo Não Encontrado" });
                return amigos;
            }

            token = repoToken.GetToken(numToken);

            if (token == null)
            {
                amigos.Add(new Amigos { ID = -1, Nome = "Token Inválido" });
                return amigos;
            }

            amigos = repositorio.GetAllListAmigos();

            foreach (var item in amigos)
            {
                if (amigoSelecionado.ID != item.ID)
                {
                    distanciaKM = repositorio.Calculate(amigoSelecionado.Latitude, amigoSelecionado.Longitude, item.Latitude, item.Longitude);
                }
                else
                {
                    distanciaKM = 0;
                }
                item.Quilometro = distanciaKM;
                //var i = amigos.Find(p => p.ID == item.ID);
            }

            var query = (from c in amigos where c.Quilometro > 0 orderby c.Quilometro select c).Take(3);

            foreach (var item in query.ToList<Amigos>())
            {
                log.IncluiLog(amigoSelecionado.Nome, amigoSelecionado.Latitude, amigoSelecionado.Longitude,
                item.Nome, item.Latitude, item.Longitude);
            }

            return query.ToList<Amigos>();
        }

    }
}
