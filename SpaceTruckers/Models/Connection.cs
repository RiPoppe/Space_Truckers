using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceTruckers.Models
{
    public class Connection
    {
        public int Id { get; set; }
        public Planet ConnectedPlanetInConnection { get; set; }
        public int ConnectedWeight { get; set; }

        public Connection() { }
        public Connection(Planet planet, int weight)
        {
            ConnectedPlanetInConnection = planet;
            ConnectedWeight = weight;
        }
    }
}
