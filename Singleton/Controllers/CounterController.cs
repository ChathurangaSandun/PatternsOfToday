using Microsoft.AspNetCore.Mvc;
using Singleton.Models;
using Singleton.Services;

namespace Singleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        private readonly ISingletonService _singleton;

        public CounterController(ISingletonService singleton)
        {
            _singleton = singleton;
        }

        public ActionResult<CounterResponse> Get()
        {
            return Ok(new CounterResponse { Number = _singleton.GetNextNumber() });
        }
    }
}