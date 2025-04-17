using Fluent.Domain.Translations;

namespace Fluent.Application.Repositories;

public class TranslationRepository : ITranslationRepository
{
    private readonly List<Translation> _translations = new();
    
    public Task<bool> CreateAsync(Translation translation)
    {
        _translations.Add(translation);
        return Task.FromResult(true);
    }

    public Task<Translation?> GetByIdAsync(Guid id)
    {
        var translation = _translations.SingleOrDefault(x => x.Id == id);
        return Task.FromResult(translation);
    }

    public Task<IEnumerable<Translation>> GetAllAsync()
    {
        return Task.FromResult(_translations.AsEnumerable());
    }

    public Task<bool> UpdateAsync(Translation translation)
    {
        var translationIndex = _translations.FindIndex(x => x.Id == translation.Id);
        if (translationIndex == -1)
        {
            return Task.FromResult(false);
        }
        
        _translations[translationIndex] = translation;
        return Task.FromResult(true);
    }

    public Task<bool> DeleteByIdAsync(Guid id)
    {
        var removedCount = _translations.RemoveAll(x => x.Id == id);
        var translationRemoved = removedCount > 0;
        return Task.FromResult(translationRemoved);
    }
}