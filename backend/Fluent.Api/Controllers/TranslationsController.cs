using Fluent.Api.Mappers;
using Fluent.Application.Repositories;
using Fluent.Contracts.Translations;
using Fluent.Domain.Translations;
using Microsoft.AspNetCore.Mvc;

namespace Fluent.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class TranslationsController : ControllerBase
{
    private readonly ITranslationRepository _translationRepository;
    
    public TranslationsController(ITranslationRepository translationRepository)
    {
        _translationRepository = translationRepository;
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTranslationRequest request)
    {
        var translation = request.MapToTranslation();
        await _translationRepository.CreateAsync(translation);
        var response = translation.MapToResponse();
        return CreatedAtAction(nameof(Get), new {id = translation.Id}, response);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get([FromRoute] Guid id)
    {
        var translation = await _translationRepository.GetByIdAsync(id);
        if (translation == null)
        {
            return NotFound();
        }
        
        var response = translation.MapToResponse();
        return Ok(response);
    }
    
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var translations = await _translationRepository.GetAllAsync();
        
        var response = translations.MapToResponse();
        return Ok(response);
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Update([FromRoute] Guid id, [FromBody] UpdateTranslationRequest request)
    {
        var translation = request.MapToTranslation(id);
        var updated = await _translationRepository.UpdateAsync(translation);
        if (!updated)
        {
            return NotFound();
        }
        
        var response = translation.MapToResponse();
        return Ok(response);
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
        var deleted = await _translationRepository.DeleteByIdAsync(id);
        if (!deleted)
        {
            return NotFound();
        }
        
        return NoContent();
    }
}