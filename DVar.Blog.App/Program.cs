using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using DVar.Blog.App;
using DVar.Blog.App.Api;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7269/") });

builder.Services.AddScoped<FeedbackApi>();
builder.Services.AddScoped<FeedbackResponseApi>();
builder.Services.AddScoped<FeedbackProcessingApi>();
builder.Services.AddBlazorBootstrap();


await builder.Build().RunAsync();