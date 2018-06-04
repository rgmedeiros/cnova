using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Amigos.Models
{
    public interface IAmigosRepositorio
    {
        IEnumerable<Amigos> GetAllAmigos();
        List<Amigos> GetAllListAmigos();
        Amigos Get(int Id);
        Amigos Add(Amigos item);
        double Calculate(double sLatitude, double sLongitude, double eLatitude,
                               double eLongitude);
    }
}
