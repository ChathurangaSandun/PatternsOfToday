using Microsoft.AspNetCore.Mvc;
using Strategy.Models;
using Strategy.Repositories;

namespace Strategy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPeopleRepository _repository;

        public PeopleController(IPeopleRepository repository)
        {
            _repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<PeopleResult> Get()
        {
            return Ok(_repository.Get());
        }
    }
}