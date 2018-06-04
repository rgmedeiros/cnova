using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using API_Amigos.Models.Entidades;

namespace API_Amigos.Models
{
    public class TokenRepositorio : ITokenRepositorio
    {
        private List<Token> tokens = new List<Token>();

        public TokenRepositorio()
        {
            Add(new Token { idToken = 1, numToken = "576RO660W4FQ3D71Q" });
            Add(new Token { idToken = 2, numToken = "13FP1660UOFF3DB14" });
            Add(new Token { idToken = 3, numToken = "21O83669WKFQ3DA16" });
            Add(new Token { idToken = 4, numToken = "327OR665W4LQ3DF17" });
            Add(new Token { idToken = 5, numToken = "44PUU6T0W44W3D110" });
            Add(new Token { idToken = 6, numToken = "503TO6105432CD311" });
            Add(new Token { idToken = 7, numToken = "693E86U0W4FQ1D11E" });
            Add(new Token { idToken = 8, numToken = "78Y206Y0G4F60DS1D" });
            Add(new Token { idToken = 9, numToken = "87K31600K4KG4D01G" });
            Add(new Token { idToken = 10, numToken = "96I02610W4F12D5SJ" });
            Add(new Token { idToken = 11, numToken = "05P93663W4F27D41B" });
            Add(new Token { idToken = 12, numToken = "13665620W4F64371Q" });
            Add(new Token { idToken = 13, numToken = "220T8665W4FWQW71R" });
            Add(new Token { idToken = 14, numToken = "361E4662W4F43D7EJ" });
        }
        
        public Token Add(Token item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            tokens.Add(item);
            return item;
        }

        public Token GetToken(string numToken)
        {
            return tokens.Find(p => p.numToken == numToken);
        }

        public Token GetNumToken(int idToken)
        {
            return tokens.Find(p => p.idToken == idToken);
        }
    }
}