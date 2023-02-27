using Blazor.ShoppingCart.Wasm;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
//builder.RootComponents.Add<App>("#app");
//builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");

builder.RootComponents.RegisterCustomElement<ShoppingCart.UI.Components.ShoppingSelect>("shopping-select");


await builder.Build().RunAsync();
