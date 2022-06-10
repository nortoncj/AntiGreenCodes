global using AntiGreenCodes.Shared;
global using System.Net.Http.Json;
global using AntiGreenCodes.Client.Services.ProductService;
using AntiGreenCodes.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IProductService, ProdcutService>();

await builder.Build().RunAsync();
