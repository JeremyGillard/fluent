namespace Fluent.Contracts.Translations;

public class TranslationsResponse
{
    public required IEnumerable<TranslationResponse> Items { get; init; } = Enumerable.Empty<TranslationResponse>();
}