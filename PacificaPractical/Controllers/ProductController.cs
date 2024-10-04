using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PacificaPractical.DBModels;
using PacificaPractical.DTOs;
using PacificaPractical.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PacificaPractical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IRepository<Product> _productRepo;
        IMapper _mapper;
        public ProductController(IRepository<Product> productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productRepo.GetAll().Where(s => !s.IsDeleted);
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(products));
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string GetByID(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
