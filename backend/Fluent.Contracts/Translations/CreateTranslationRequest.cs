namespace Fluent.Contracts.Translations;

public class CreateTranslationRequest
{
    public required string NativeLanguage { get; init; }

    public required string NativeLanguageWord { get; init; }

    public required string TargetLanguage { get; init; }

    public required string TargetLanguageWord { get; init; }
}