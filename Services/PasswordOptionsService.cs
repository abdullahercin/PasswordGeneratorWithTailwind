using PasswordGeneratorWithTailwind.Models;

namespace PasswordGeneratorWithTailwind.Services;

public class PasswordOptionsService : IPasswordOptionsService
{
    private const string Upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string Lower = "abcdefghijklmnopqrstuvwxyz";
    private const string Numbers = "0123456789";
    private const string Symbols = "!@#$%^&*()_+-=[]{}|;:',.<>?";

    public IReadOnlyList<PasswordOption> GetPasswordOptions()
    {
        return new List<PasswordOption>
        {
            new PasswordOption { Id = "uppercase", Label = "Büyük harf", IsIncluded = true, CharSet = Upper },
            new PasswordOption { Id = "lowercase", Label = "Küçük harf", IsIncluded = true, CharSet = Lower },
            new PasswordOption { Id = "numbers", Label = "Rakam", IsIncluded = true, CharSet = Numbers },
            new PasswordOption { Id = "symbols", Label = "Özel karakter", IsIncluded = true, CharSet = Symbols }
        };
    }
}