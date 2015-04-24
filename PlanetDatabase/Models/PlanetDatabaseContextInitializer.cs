using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PlanetDatabase.Models
{
    public class PlanetDatabaseContextInitializer : DropCreateDatabaseAlways<PlanetDatabaseContext>
    {
        protected override void Seed(PlanetDatabaseContext context)
        {
            var planets = new List<Planet>
            {
                new Planet() {Name = "Mercury", DistanceFromSunInKm = 57910000},
                new Planet() {Name = "Venus", DistanceFromSunInKm = 108200000},
                new Planet() {Name = "Earth", DistanceFromSunInKm = 149600000},
                new Planet() {Name = "Mars", DistanceFromSunInKm = 227940000},
                new Planet() {Name = "Jupiter", DistanceFromSunInKm = 778330000},
                new Planet() {Name = "Saturn", DistanceFromSunInKm = 1424600000},
                new Planet() {Name = "Uranus", DistanceFromSunInKm = 2873550000},
                new Planet() {Name = "Neptune", DistanceFromSunInKm = 4501000000},
                new Planet() {Name = "Pluto", DistanceFromSunInKm = 5945900000}
            };

            planets.ForEach(p => context.Planets.Add(p));

            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}