using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authorization
{
    public static class PlaneAuthorization
    {
        public static List<Plane> planes = new List<Plane>()
        {
            new Plane(),
            new Plane(),
            new Plane(),
            new Plane(),
        };
        public static bool CheckAuthorization()
        {
            planes.Where(plane => plane.DepartureDate < DateTime.Now || plane.DepartureDate > plane.ArrivalDate).Count();
            if(planes.Count > 0)
            {
                return false;
            }
            return true;
        }
        public static Plane[] ImpostorPlanes()
        {
            return planes.Where(plane => plane.DepartureDate < DateTime.Now || plane.DepartureDate > plane.ArrivalDate).ToArray();
        }
    }
}
