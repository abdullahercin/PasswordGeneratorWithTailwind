namespace PasswordGeneratorWithTailwind.Services;

public interface IPasswordGeneratorService
{
    Task<string> GeneratePasswordAsync(string allChars, int length);
}