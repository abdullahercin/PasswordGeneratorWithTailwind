using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PasswordGeneratorWithTailwind;
using PasswordGeneratorWithTailwind.Memento;
using PasswordGeneratorWithTailwind.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IPasswordGeneratorService, PasswordGeneratorService>();
builder.Services.AddScoped<IPasswordOptionsService, PasswordOptionsService>();
builder.Services.AddScoped<PasswordCaretaker>();

await builder.Build().RunAsync();
