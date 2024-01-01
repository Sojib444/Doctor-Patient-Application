using Microsoft.EntityFrameworkCore;
using Telemedicine.Application.Repository;
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
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<DbContext>();

//AutoMapper COnfiguration
builder.Services.AddAutoMapper(typeof(Program));

//Dbcontext Configuration
builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(connectionstring));

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
