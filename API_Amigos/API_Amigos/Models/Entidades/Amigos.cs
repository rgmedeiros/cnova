using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Amigos.Models
{
    public class Amigos
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Quilometro { get; set; }
    }
}