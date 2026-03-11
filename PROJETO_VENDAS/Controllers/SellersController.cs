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
    }
}
