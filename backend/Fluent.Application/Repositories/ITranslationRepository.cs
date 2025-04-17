using Fluent.Domain.Translations;

namespace Fluent.Application.Repositories;

public interface ITranslationRepository
{
    Task<bool> CreateAsync(Translation translation);
    
    Task<Translation?> GetByIdAsync(Guid id);
    
    Task<IEnumerable<Translation>> GetAllAsync();
    
    Task<bool> UpdateAsync(Translation translation);
    
    Task<bool> DeleteByIdAsync(Guid id);
}