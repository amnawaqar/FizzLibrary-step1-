using FizzLibrary.Shared.Interface;
using FizzLibrary.Shared.Service;
using Microsoft.AspNetCore.ResponseCompression;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IFizzBuzz, FizzBuzzService>();
builder.Services.AddSingleton<IFizzBuzz, FizzService>();
builder.Services.AddSingleton <IFizzBuzz, BuzzService >();
builder.Services.AddSingleton<IFizzBuzz, NumberService>();
builder.Services.AddSingleton<FizzBuzzStrategy>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["ApiBaseAddress"]) });
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
