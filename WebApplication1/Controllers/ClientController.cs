using Microsoft.AspNetCore.Mvc;
using WebApplication1.IRepository;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
        private IClientRepository _repository;
        public ClientController(IClientRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("List")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetClient()
        {
           var items = _repository.GetClient;
            return Ok(items);
        }

        [HttpGet("GetByID")]
        public IActionResult GetClientByID(int Id)
        {
            var items = _repository.GetClientByID(Id);
            return Ok(items);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddClient(Livre client)
        {
            return Ok(await _repository.AddClient(client));
        }
    }
}
