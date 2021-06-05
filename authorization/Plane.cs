using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace authorization
{
    public class Plane
    {
        public Guid PassportID { get; private set; }
        public DateTime DepartureDate { get; private set; }
        public DateTime ArrivalDate { get; private set; }
        public int FlightNumber { get; private set; }

        public Plane()
        {
            Random rand = new Random();

            PassportID = Guid.NewGuid();
            DepartureDate = DateTime.UtcNow.AddDays(rand.Next(1, 16));
            ArrivalDate = DateTime.UtcNow.AddDays(rand.Next(1, 16));
            FlightNumber = rand.Next(0, 101);
        }

        public Plane(Guid passportID, DateTime departureDate, DateTime arrivalDate, int flightNumber)
        {
            PassportID = passportID;
            DepartureDate = departureDate;
            ArrivalDate = arrivalDate;
            FlightNumber = flightNumber;
        }
    }
}
