using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ap2_poo
{
    [ApiController]
    [Route("api/[controller]")]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierRepository repository;
        public SuppliersController(ISupplierRepository repository)
        {
            this.repository = new SupplierRepository();
        }
        [HttpGet]
        public IEnumerable<Supplier>Get()
        {
            return repository.GetAll();
        }
    }
}