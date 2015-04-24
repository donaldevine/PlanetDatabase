using System.Linq;

namespace PlanetDatabase.Models
{
    public interface IRepository
    {
        IQueryable<Planet> GetAllPlanets();
        Planet GetPlanet(int id);
    }
}