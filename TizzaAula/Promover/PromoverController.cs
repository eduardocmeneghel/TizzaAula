using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TizzaAula
{
    [ApiController]
    [Route("[controller]")]
    public class PromoverController : ControllerBase
    {
        private IServPromover _servPromover;

        public PromoverController(IServPromover servPromover)
        {
            _servPromover = servPromover;
        }

        [HttpPost]
        public IActionResult Inserir(InserirPromoverDTO inserirPromoverDto)
        {
            try
            {
                _servPromover.Inserir(inserirPromoverDto);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
