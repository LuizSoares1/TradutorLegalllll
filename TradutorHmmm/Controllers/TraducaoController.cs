using Microsoft.AspNetCore.Mvc;
using TradutorHmmm.Data;
using TradutorHmmm.Models;

namespace TradutorHmmm.Controllers
{
    public class TraducaoController : ControllerBase
    {
        private readonly TraducaoContext _context;

        public TraducaoController(TraducaoContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionarTraducao([FromBody] Traducao traducao)
        {
            _context.Traducaos.Add(traducao);
            _context.SaveChanges();
            return Ok();
        }

        [HttpGet]
        public IActionResult ObterTraducao(string palavra)
        {
            var traducao = _context.Traducaos.FirstOrDefault(e => e.Palavra == palavra);
            if (traducao == null)
            {
                return NotFound();
            }
            return Ok(traducao);
        }
    }
}
