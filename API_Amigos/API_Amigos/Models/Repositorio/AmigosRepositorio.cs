using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Amigos.Models
{
    public class AmigosRepositorio : IAmigosRepositorio
    {
        private List<Amigos> amigos = new List<Amigos>();
        private int nextId = 1;

        public AmigosRepositorio()
        {
            Add(new Amigos { Nome = "Renan Pozzetti", Latitude = 47.80937, Longitude = 15.66244 });
            Add(new Amigos { Nome = "Giovana Reis", Latitude = 56.09742, Longitude = 10.98732 });
            Add(new Amigos { Nome = "Renato Medeiros", Latitude = 65.10835, Longitude = 11.78430 });
            Add(new Amigos { Nome = "Vagner Leite", Latitude = 35.09512, Longitude = 19.75092 });
            Add(new Amigos { Nome = "Marco Godoi", Latitude = 27.0985, Longitude = 11.98764 });
            Add(new Amigos { Nome = "Vlamir Matheus", Latitude = 38.9153, Longitude = 13.41209 });
            Add(new Amigos { Nome = "Marcelo Paiva", Latitude = 89.53201, Longitude = 11.78926 });
            Add(new Amigos { Nome = "Fabio Mantovanni", Latitude = 74.10953, Longitude = 10.93763 });
        }

        public Amigos Add(Amigos item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            item.ID = nextId++;
            amigos.Add(item);
            return item;
        }

        public Amigos Get(int Id)
        {
            return amigos.Find(a => a.ID == Id);
        }

        public IEnumerable<Amigos> GetAllAmigos()
        {
            return amigos;
        }

        public List<Amigos> GetAllListAmigos()
        {
            return amigos;
        }

        public double Calculate(double sLatitude, double sLongitude, double eLatitude,
                               double eLongitude)
        {
            var radiansOverDegrees = (Math.PI / 180.0);

            var sLatitudeRadians = sLatitude * radiansOverDegrees;
            var sLongitudeRadians = sLongitude * radiansOverDegrees;
            var eLatitudeRadians = eLatitude * radiansOverDegrees;
            var eLongitudeRadians = eLongitude * radiansOverDegrees;

            var dLongitude = eLongitudeRadians - sLongitudeRadians;
            var dLatitude = eLatitudeRadians - sLatitudeRadians;

            var result1 = Math.Pow(Math.Sin(dLatitude / 2.0), 2.0) +
                          Math.Cos(sLatitudeRadians) * Math.Cos(eLatitudeRadians) *
                          Math.Pow(Math.Sin(dLongitude / 2.0), 2.0);

            // Using 3956 as the number of miles around the earth
            var result2 = 3956.0 * 2.0 *
                          Math.Atan2(Math.Sqrt(result1), Math.Sqrt(1.0 - result1));

            return result2;
        }
    }
}