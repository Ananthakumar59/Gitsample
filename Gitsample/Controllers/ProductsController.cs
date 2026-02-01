using Gitsample.Models;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gitsample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase

    {
        List<Product> products = new List<Product>();
        public ProductsController()
        {
            products.Add(new Product() { Id = 1, Name = "Laptop", Price = 999.99M, Description = "A high-performance laptop." });
            products.Add(new Product() { Id = 2, Name = "Smartphone", Price = 499.99M, Description = "A latest model smartphone." });
            products.Add(new Product() { Id = 3, Name = "Tablet", Price = 299.99M, Description = "A lightweight tablet." });
        }
        // GET: api/<ProductsController>
        [HttpGet]
        public List<Product> Get()
        {
            return products.ToList();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
