using ChainOfResponsibility.Processors;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibility.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var processors = new IJokeProcessor[]
            {
                new DadJokeProcessor(),
                new ChuckNorrisJokeProcessor()
            };

            foreach (var processor in processors)
            {
                if (processor.CanProcess(id))
                {
                    return Ok(processor.Process());
                }
            }

            return NotFound();
        }
    }
}