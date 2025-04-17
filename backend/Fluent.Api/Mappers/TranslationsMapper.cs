using Fluent.Contracts.Translations;
using Fluent.Domain.Translations;

namespace Fluent.Api.Mappers;

static public class TranslationsMapper
{
    public static Translation MapToTranslation(this CreateTranslationRequest request)
    {
        return new Translation
        {
            Id = Guid.NewGuid(),
            NativeLanguage = request.NativeLanguage,
            NativeLanguageWord = request.NativeLanguageWord,
            TargetLanguage = request.TargetLanguage,
            TargetLanguageWord = request.TargetLanguageWord
        };
    }
    
    public static Translation MapToTranslation(this UpdateTranslationRequest request, Guid id)
    {
        return new Translation
        {
            Id = id,
            NativeLanguage = request.NativeLanguage,
            NativeLanguageWord = request.NativeLanguageWord,
            TargetLanguage = request.TargetLanguage,
            TargetLanguageWord = request.TargetLanguageWord
        };
    }

    public static TranslationResponse MapToResponse(this Translation translation)
    {
        return new TranslationResponse
        {
            Id = translation.Id,
            NativeLanguage = translation.NativeLanguage,
            NativeLanguageWord = translation.NativeLanguageWord,
            TargetLanguage = translation.TargetLanguage,
            TargetLanguageWord = translation.TargetLanguageWord
        };
    }

    public static TranslationsResponse MapToResponse(this IEnumerable<Translation> translations)
    {
        return new TranslationsResponse
        {
            Items = translations.Select(MapToResponse)
        };
    }
}