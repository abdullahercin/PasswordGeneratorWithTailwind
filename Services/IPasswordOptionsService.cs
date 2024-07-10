using PasswordGeneratorWithTailwind.Models;

namespace PasswordGeneratorWithTailwind.Services;

public interface IPasswordOptionsService
{
    IReadOnlyList<PasswordOption> GetPasswordOptions();
}