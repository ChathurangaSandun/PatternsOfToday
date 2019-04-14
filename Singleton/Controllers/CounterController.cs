using Microsoft.AspNetCore.Mvc;
using Singleton.Models;
using Singleton.Services;

namespace Singleton.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CounterController : ControllerBase
    {
        public ActionResult<CounterResponse> Get()
        {
            return Ok(new CounterResponse { Number = SingletonService.Instance.GetNextNumber() });
        }
    }
}