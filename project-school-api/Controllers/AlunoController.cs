using Microsoft.AspNetCore.Mvc;

namespace project_school_api.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class AlunoController : Controller
    {
        public AlunoController()
        {
            
        }

         [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        [HttpGet("{alunoId}")]
        public IActionResult Get(int alunoId)
        {
            return Ok();
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        [HttpPut("{alunoId}")]
        public IActionResult Put(int alunoId)
        {
            return Ok();
        }

        [HttpDelete("{alunoId}")]
        public IActionResult Delete(int alunoId)
        {
            return Ok();
        }
    }
}