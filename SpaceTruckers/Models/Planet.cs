using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaceTruckers.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Connection> ConnectedPlanetsInplanet { get; set; }

        // Variables used by dijkstra's algorithm

        private Planet _previousPlanet = null;
        private int _pathWeight = int.MaxValue;
        private bool _visited = false;
       
        // Constructor
        public Planet() 
        {
            ConnectedPlanetsInplanet = new List<Connection>();
        }
        public Planet(string name)
        {
            ConnectedPlanetsInplanet = new List<Connection>();
            if (!String.IsNullOrEmpty(name))
            {
                Name = name;
            }
            else
            {
                Name = "Default";
            }
        }

        public void ResetShortestPath()
        {
            _previousPlanet = null;
            _pathWeight = int.MaxValue;
            _visited = false;
        }

        public bool SetConnection(Connection connection)
        {
            //if (!ConnectedPlanets.Any(plan => plan.ConnectedPlanet.Equals(connection.ConnectedPlanet)))
            {
                this.ConnectedPlanetsInplanet.Add(connection);
                return true;
            }
            //else
            //{
            //    Console.WriteLine("This connection already exists: " + Name + " > " + connection.ConnectedPlanet.Name);
            //    return false;
            //}
        }
        
    }
}
