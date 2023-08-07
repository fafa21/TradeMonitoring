using ApplicationCore;
using ApplicationCore.Interface;
using ApplicationCore.Services;
using Infrastructure;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TradeMonitoringContext>();
//builder.Services.AddDbContext<TradeMonitoringContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("")));//builder.Services.AddDbContext<TradeMonitoringContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("")));
//builder.Services.AddScoped(typeof(IGeneralRepository<,>), typeof(GeneralRepository<,>));
builder.Services.AddScoped(IUserRepository, UserRepository);


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
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
