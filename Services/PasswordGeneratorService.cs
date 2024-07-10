namespace PasswordGeneratorWithTailwind.Services;

public class PasswordGeneratorService : IPasswordGeneratorService
{
    public async Task<string> GeneratePasswordAsync(string allChars, int length)
    {
        return await Task.Run(() =>
        {
            var random = new Random();
            return new string(Enumerable.Repeat(allChars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        });
    }
}