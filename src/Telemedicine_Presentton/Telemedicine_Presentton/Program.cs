using Microsoft.EntityFrameworkCore;
using Telemedicine.EntityFramework.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//ConnectionStrig
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Sevice Dependency
builder.Services.AddScoped<ApplicationDbContext,ApplicationDbContext>();

//DbContext Configuration
builder.Services.AddDbContext<ApplicationDbContext>(contex => contex.UseSqlServer(connectionString));

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
