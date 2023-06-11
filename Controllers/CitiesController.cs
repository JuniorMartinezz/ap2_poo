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

        public CitiesController()
        {
            this.repository = new CityRepository();
        }

        [HttpGet]
        public IEnumerable<City> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public City Get(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public IActionResult Post([FromBody] City item)
        {
            repository.Save(item);
            return Ok(
                new
                {
                    statusCode = 200,
                    message = "Cadastrado com sucesso",
                    item
                }
            );
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return Ok(new { statusCode = 200, message = "Cidade excluída com sucesso" });
        }

        [HttpPut]
        public IActionResult Put([FromBody] City item)
        {
            repository.Update(item);
            return Ok(
                new
                {
                    statusCode = 200,
                    message = item.Name + "Cidade atualizada com sucesso",
                    item
                }
            );
        }
    }
}
