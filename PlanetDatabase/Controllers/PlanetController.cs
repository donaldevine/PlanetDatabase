using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PlanetDatabase.Models;

namespace PlanetDatabase.Controllers
{
    public class PlanetController : ApiController
    {
        private PlanetDatabaseContext db = new PlanetDatabaseContext();

        // GET: api/Planet
        public IQueryable<Planet> GetPlanets()
        {
            return db.Planets;
        }

        // GET: api/Planet/5
        [ResponseType(typeof(Planet))]
        public IHttpActionResult GetPlanet(int id)
        {
            Planet planet = db.Planets.Find(id);
            if (planet == null)
            {
                return NotFound();
            }

            return Ok(planet);
        }

        // PUT: api/Planet/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPlanet(int id, Planet planet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != planet.Id)
            {
                return BadRequest();
            }

            db.Entry(planet).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlanetExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Planet
        [ResponseType(typeof(Planet))]
        public IHttpActionResult PostPlanet(Planet planet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Planets.Add(planet);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = planet.Id }, planet);
        }

        // DELETE: api/Planet/5
        [ResponseType(typeof(Planet))]
        public IHttpActionResult DeletePlanet(int id)
        {
            Planet planet = db.Planets.Find(id);
            if (planet == null)
            {
                return NotFound();
            }

            db.Planets.Remove(planet);
            db.SaveChanges();

            return Ok(planet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PlanetExists(int id)
        {
            return db.Planets.Count(e => e.Id == id) > 0;
        }
    }
}