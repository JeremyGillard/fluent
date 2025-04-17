namespace Fluent.Domain.Translations;

public class Translation
{
    public required Guid Id { get; init; }
    
    public required string NativeLanguage { get; set; }

    public required string NativeLanguageWord { get; set; }

    public required string TargetLanguage { get; set; }

    public required string TargetLanguageWord { get; set; }
}