using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PROJETO_VENDAS.Data;
using PROJETO_VENDAS.Models;

namespace PROJETO_VENDAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {

        private readonly SalesWebMvcContext _context;

        public SellersController(SalesWebMvcContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Seller>> GetSellers()
        {
            var sellers = _context.Sellers.ToList();
            return Ok(sellers);
        }

        [HttpGet("{id}")]
        public ActionResult<Seller> GetSeller(int id)
        {
            var seller = _context.Sellers.Find(id);

            if (seller == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(seller);
            }
        }

        [HttpPost]
        public ActionResult<Seller> CreateSeller(Seller seller)
        {
            _context.Sellers.Add(seller);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetSeller), new { id = seller.Id }, seller);
        }

        [HttpPut]
        public ActionResult<Seller> PutSeller(int id, Seller seller)
        {
            if (id != seller.Id)
            {
                return BadRequest();
            }
            var existingSeller = _context.Sellers.Find(id); 
            if (existingSeller == null) 
            {
                return NotFound();
            }
            existingSeller.Name = seller.Name;
            existingSeller.Email = seller.Email;
            existingSeller.BirthDate = seller.BirthDate;
            existingSeller.BaseSalary = seller.BaseSalary;
            existingSeller.DepartmentId = seller.DepartmentId;

            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteSeller(int id) 
        {
            var existingSeller = _context.Sellers.Find(id);
            if ( existingSeller == null)
            {
                return NotFound();
            }
            _context.Sellers.Remove(existingSeller);
            _context.SaveChanges();
            return NoContent();

        }

    }
}
