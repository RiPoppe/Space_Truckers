using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SpaceTruckers.Data;
using System;
using System.Linq;
using System.Diagnostics;

namespace SpaceTruckers.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            
            using var context = new DatabaseContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<DatabaseContext>>());

            // Clear all the data in the database
            context.RemoveRange(context.Planets);
            context.RemoveRange(context.Connections);
            context.RemoveRange(context.GalaxyMaps);
            context.SaveChanges();  
            
            Planet A = new Planet("A");
            Planet B = new Planet("B");
            Planet C = new Planet("C");
            Planet D = new Planet("D");
            Planet E = new Planet("E");
            Planet F = new Planet("F");
            Planet G = new Planet("G");
            Planet H = new Planet("H");
            Planet I = new Planet("I");
            Planet J = new Planet("J");
            
            context.Planets.AddRange(
                A, B, C, D, E, F, G, H, I, J
                );


            context.SaveChanges();

            
            Connection connectionAB = new Connection(B, 5);
            Connection connectionAC = new Connection(C, 4);
            Debug.WriteLine("connection ab");
            A.SetConnection(connectionAB);
            Debug.WriteLine("connection ac");
            A.SetConnection(connectionAC);
            //if (A.SetConnection(connection1))
            //{

            context.Connections.AddRange(connectionAB,connectionAC);

            //}


            context.SaveChanges();
            
        }
    }
}
