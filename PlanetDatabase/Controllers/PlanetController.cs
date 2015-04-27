using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using PlanetDatabase.Models;

namespace PlanetDatabase.Controllers
{
    public class PlanetController : ApiController
    {
        private readonly IRepository _repository;

        public PlanetController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IQueryable<Planet> Get()
        {
            return _repository.GetAllPlanets();
        }

        [HttpGet]
        public Planet Get(int id)
        {
            return _repository.GetPlanet(id);
        }

    }
}