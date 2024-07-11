namespace PasswordGeneratorWithTailwind.Models;

public class PasswordOption
{
    public required string Id { get; init; }
    public required string Label { get; init; }
    public bool IsIncluded { get; set; }
    public required string CharSet { get; init; }
}