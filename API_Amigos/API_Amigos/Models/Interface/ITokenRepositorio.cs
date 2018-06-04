using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API_Amigos.Models.Entidades;

namespace API_Amigos.Models
{
    interface ITokenRepositorio
    {
        Token GetToken(string numToken);
        Token GetNumToken(int idToken);
        Token Add(Token item);
    }
}
