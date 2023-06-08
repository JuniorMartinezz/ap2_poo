using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ap1_poo.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using poo_ap1;

namespace ap1_poo.Controllers
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