using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Runtime.InteropServices.JavaScript;
using Juegecitos.BANA;
using BANARCL;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var host = await GRHost.Create();

builder.Services.AddScoped(sp => host);

//await JSHost.ImportAsync("BANARCL/Viewer", "../_content/BANARCL/Viewer.razor.js");
await builder.Build().RunAsync();
