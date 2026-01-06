using BlazorCookbook.App.Client.Chapter2.Data;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddTransient<SuggestionsApi>();
//builder.Services.AddScoped<SuggestionsApi>();

await builder.Build().RunAsync();
