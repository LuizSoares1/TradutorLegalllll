using Microsoft.AspNetCore.Mvc;
using TradutorHmmm.Data;
using TradutorHmmm.Models;


namespace TradutorHmmm.Controllers;

[ApiController]
[Route("[Controller]")]
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
        return CreatedAtAction(nameof(ObterTraducao), new {palavra =  traducao.Palavra}, traducao);
    }

    [HttpGet]
    public IActionResult ObterTraducao([FromBody]string palavra)
    {
        var traducao = _context.Traducaos.FirstOrDefault(e => e.Palavra == palavra);
        if (traducao == null)
        {
            return NotFound();
        }
        return Ok(traducao);
    }
}
