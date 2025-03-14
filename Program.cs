using calcmaster_webapp.Interfaces.AverageFuelConsumption;
using calcmaster_webapp.Interfaces.Salary;
using calcmaster_webapp.Interfaces.VehicleAutonomy;
using calcmaster_webapp.Models;
using calcmaster_webapp.Models.Salary;
using calcmaster_webapp.Models.simple.context;
using calcmaster_webapp.Models.simple.factories;
using calcmaster_webapp.Models.VehicleAutonomy;

var builder = WebApplication.CreateBuilder(args);

#region Configure Services
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<SimpleCalculatorFactory>();
builder.Services.AddScoped<SimpleCalculatorContext>();

builder.Services.AddScoped<TaxSetup>();
builder.Services.AddTransient<IIrTaxCalculator, IrTaxCalculator>();
builder.Services.AddTransient<IInssTaxCalculator, InssTaxCalculator>();
builder.Services.AddTransient<INetSalaryCalculator, NetSalaryCalculator>();

builder.Services.AddSingleton<IAverageFuelConsumptionCalculator, AverageFuelConsumptionCalculator>();

builder.Services.AddSingleton<IVehicleAutonomyCalculator, VehicleAutonomyCalculator>();
#endregion

#region Configure App
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
#endregion
