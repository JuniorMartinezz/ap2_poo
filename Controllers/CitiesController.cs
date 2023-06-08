using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ap2_poo.Data.Repositories;
using ap2_poo.Domain;
using ap2_poo.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ap2_poo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityRepository repository;

        public CitiesController(ICityRepository repository)
        {
            this.repository = new CityRepository();
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return repository.GetAll();
        }
    }
}
