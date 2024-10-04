using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PacificaPractical.DBModels;
using PacificaPractical.DTOs;
using PacificaPractical.Repository;


namespace PacificaPractical.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellerController : ControllerBase
    {
        IRepository<Seller> _sellerRepo;
        IMapper _mapper;

        public SellerController(IRepository<Seller> sellerRepo, IMapper mapper)
        {
            _sellerRepo = sellerRepo;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var sellers = _sellerRepo.GetAll().Where(s => s.Enabled == true);
            return Ok(sellers);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var seller = _sellerRepo.GetById(id);
            return Ok(_mapper.Map<SellerDTO>(seller));
        }

        [HttpPost("Create")]
        public IActionResult Post(SellerDTO model)
        {
            if (model == null) return BadRequest();
            var sellerToAdd = new Seller
            {
                Name = model.Name,
                Enabled = model.Enabled,
                DisplayOrder = model.DisplayOrder,
                Products = _mapper.Map<List<Product>>(model.Products)
            };

            _sellerRepo.Insert(sellerToAdd);
            _sellerRepo.Save();
            return Ok();

        }

        [HttpPut("Update")]
        public IActionResult Put(SellerDTO seller)
        {
            if (seller == null) return BadRequest();

            _sellerRepo.Update(_mapper.Map<Seller>(seller));
            _sellerRepo.Save();
            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var sellerToDelete = _sellerRepo.GetById(id);
            sellerToDelete.DeletedDate = DateTime.UtcNow;
            sellerToDelete.IsDeleted = true;
            _sellerRepo.Update(sellerToDelete);
            _sellerRepo.Save();
            return Ok();
        }
    }
}
