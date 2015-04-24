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
        private IRepository _repository;

        public PlanetController(IRepository repository)
        {
            _repository = repository;
        }

        public IQueryable<Planet> Get()
        {
            return _repository.GetAllPlanets();
        }

        public Planet Get(int id)
        {
            return _repository.GetPlanet(id);
        }

    }
}