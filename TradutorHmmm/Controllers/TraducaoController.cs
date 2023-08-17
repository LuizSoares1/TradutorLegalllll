using Microsoft.AspNetCore.Mvc;
using TradutorHmmm.Data;
using TradutorHmmm.Data.Dto;
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

    //Adiciona as duas caralhas de strings

    [HttpPost]
    public IActionResult AdicionarTraducao([FromBody] Traducao traducao)
    {
        if(traducao == null || string.IsNullOrWhiteSpace(traducao.Palavra) || string.IsNullOrWhiteSpace(traducao.PalavraTraduzida))
        {
            return BadRequest();
        }
        _context.Traducaos.Add(traducao);
        _context.SaveChanges();
        return Ok();    
    }

    //Retorna justamente a porra da tradução
    [HttpGet]
    public IActionResult ObterTraducao([FromBody]ObterTraducaoRequest request)
    {
        var traducao = _context.Traducaos.FirstOrDefault(e => e.Palavra == request.Palavra);
        if (traducao == null)
        {
            return NotFound();
        }
        return Ok(traducao);
    }
}
