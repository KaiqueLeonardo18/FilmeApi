using AutoMapper;
using FillmeApiPratica.Data;
using FillmeApiPratica.Data.Dtos;
using FillmeApiPratica.Model;
using Microsoft.AspNetCore.Mvc;

namespace FillmeApiPratica.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private readonly FilmeContext _context;
    private readonly IMapper _mapper;

    public FilmeController(FilmeContext context,
                           IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] CreateFilmeDto filmes)
    {
        var filme = _mapper.Map<Filme>(filmes);
        _context.Filmes.Add(filme);
        _context.SaveChanges();

        return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);
    }

    [HttpGet]
    public IEnumerable<ReadFilmeDto> RecuperaFilme([FromQuery] int skip = 0, [FromQuery] int take = 10)
    { 
        return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take).ToList());
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(x => x.Id == id);

        if (filme == null) NotFound();

        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpGet("{id}")]
    public IActionResult RecuperaFilmePorId(int id)
    {
        var filmes = _context.Filmes.SingleOrDefault(x => x.Id == id);
        if (filmes == null) NotFound();

        var filmeDto = _mapper.Map<ReadFilmeDto>(filmes);

        return Ok(filmeDto);
    }

    [HttpDelete("{id}")]
    public IActionResult RemoverFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(x => x.Id == id);
        if (filme == null) NotFound();

        _context.Filmes.Remove(filme);
        _context.SaveChanges();

        return NoContent();
    }
}
