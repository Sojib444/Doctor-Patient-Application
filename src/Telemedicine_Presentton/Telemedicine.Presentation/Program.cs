using Autofac;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Telemedicine.Application.Repository;
using Telemedicine.Application.Services.DoctorServices;
using Telemedicine.Application.SignalR.Hubs;
using Telemedicine.Application.UnitofWork;
using Telemedicine.Domain.Repository;
using Telemedicine.Domain.UnitofWork;
using Telemedicine.EntityFramework.Core;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Conectionstring
var connectionstring = builder.Configuration.GetConnectionString("Default");

//service resister
builder.Services.AddScoped<IApplicationDbContex, ApplicationDbContext>();
builder.Services.AddScoped<IApplicationUnitofWork, ApplicationUnitofWork>();
builder.Services.AddScoped<IUnitofWork, UniOfWork>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IDoctorServices, DoctorServcies>();
builder.Services.AddScoped<DbContext>();
//builder.Services.AddScoped<UserRegistration>();

//Add service to the container
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddSignalR();


//Dbcontext Configuration
builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(connectionstring));
builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapHub<UserHub>("/hubs/countuser");

app.Run();
