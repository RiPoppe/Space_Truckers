using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceTruckers.Models
{
    public class GalaxyMap
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public List<Planet> Planets { get; set; }

        public Connection SetConnectionOneWay(Planet A, Planet B, int weightAtoB)
        {
            Connection connection = new Connection(B,weightAtoB);
            A.SetConnection(connection);
            return connection;

        }
        public Connection SetConnectionBothWays(Planet A, Planet B, int weightAB, int weightBA)
        {
            return null;

        }

    }
}
