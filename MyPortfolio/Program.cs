using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MyPortfolio;
using MyPortfolio.Services; // Ensure you have this import

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient for WordPress API
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://public-api.wordpress.com/rest/v1.1/sites/brendanbondurant.wordpress.com/")
});

// Register WordPressService
builder.Services.AddScoped<WordPressService>();

builder.Services.AddBlazorBootstrap();

await builder.Build().RunAsync();
