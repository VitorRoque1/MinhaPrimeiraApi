using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Data;
using MinhaPrimeiraApi.Data.Dtos;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    private ApiContext _context;
    private IMapper _mapper;

    public ApiController(ApiContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult AdicionarInfo([FromBody] CreateApi apiDto)
    {
        Api info = _mapper.Map<Api>(apiDto); 
        _context.Apis.Add(info);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaInfoPorId), new { id = info.Id }, info);
    }
    [HttpGet]
    public IEnumerable<Api> RecuperaInfoPorId([FromQuery] int skip = 0, [FromQuery] int take = 10)
    {
        return _context.Apis.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]

    public IActionResult RecuperaMinhaApi(int id)
    {
        var Apis = _context.Apis.FirstOrDefault(api  => api.Id == id);
        if (Apis == null) return NotFound();
        var ApiDto = _mapper.Map<Api>(Apis);
        return Ok(Apis);        
    }

    [HttpPut("{id}")]
    public IActionResult AtualizaSerie(int id, [FromBody] UpdateApiDto ApiDto)
    {
        var info = _context.Apis.FirstOrDefault(info => info.Id == id);
        if (info == null) return NotFound();
        _mapper.Map(ApiDto, info);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpPatch("{id}")]
    public IActionResult AtualizaApiParcial(int id, [FromBody] JsonPatchDocument <UpdateApiDto> patch)
    {
        var Api = _context.Apis.FirstOrDefault(api => api.Id == id);
        if (Api == null) return NotFound();

        var ApiParaAtualizar = _mapper.Map<UpdateApiDto>(Api);
        patch.ApplyTo(ApiParaAtualizar, ModelState);

        if(! TryValidateModel(ApiParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }

        _mapper.Map(ApiParaAtualizar, Api);
        _context.SaveChanges();
        return NoContent();

    }

    [HttpDelete("{id}")]
    public IActionResult DeleteApi(int id)
    {
        var Api = _context.Apis.FirstOrDefault(Api => Api.Id == id);
        if (Api == null) return NotFound();
        _context.Apis.Remove(Api);
        _context.SaveChanges();
        return NoContent();
    }
}
