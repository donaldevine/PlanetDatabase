namespace PlanetDatabase.Models
{
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long DistanceFromSunInKm { get; set; }
    }
}