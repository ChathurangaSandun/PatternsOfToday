using System.Collections.Generic;
using ChainOfResponsibility.Processors;
using Microsoft.AspNetCore.Mvc;

namespace ChainOfResponsibility.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JokesController : ControllerBase
    {
        private readonly IEnumerable<IJokeProcessor> _processors;

        public JokesController(IEnumerable<IJokeProcessor> processors)
        {
            _processors = processors;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            foreach (var processor in _processors)
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