using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoEcommerceApp.Domain;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoEcommerceApp.Controllers
{
    [Produces ("application/json")]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET: api/Products
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return new Product[]
            {
                new Product (1, "Oats", new decimal(3.07)),
                new Product (2, "ToothPaste", new decimal(10.89)),
                new Product (3, "Television", new decimal(500.90))
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Products
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Product product) 
            => (await )

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }


    }


}
