using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanetDatabase.Models
{
    public class Repository : IRepository
    {
        private readonly PlanetDatabaseContext _db;

        public Repository(PlanetDatabaseContext db)
        {
            this._db = db;
        }

        public IQueryable<Planet> GetAllPlanets()
        {
            return _db.Planets;
        }

        public Planet GetPlanet(int id)
        {
            return _db.Planets.FirstOrDefault(p => p.Id == id);
        }
    }
}