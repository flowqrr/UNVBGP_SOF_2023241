using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using sof_feleves.Logic;
using sof_feleves.Logic.Interfaces;
using sof_feleves.Models;
using sof_feleves.Repository;
using sof_feleves.Repository.Repositories;
using sof_feleves.Services;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options
    .UseNpgsql(connectionString)
    .UseLazyLoadingProxies());

builder.Services.AddDefaultIdentity<SiteUser>(options =>
{
    // TODO: turn on
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 4;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<AppDbContext>();

builder.Services.AddAuthentication()
    .AddMicrosoftAccount( opt =>
    {
        opt.ClientId = "536b9d75-52bd-41e5-9822-e2221a298400";
        opt.ClientSecret = "BqF8Q~3VypE4Mc4js78ywHBbGJrFViTTpLCbWaE8";
        opt.SaveTokens = true;
    });

builder.Services.AddTransient<IEmailSender, EmailSender>();

builder.Services.AddTransient<IRepository<Service>, ServiceRepository>();
builder.Services.AddTransient<IRepository<Post>, PostRepository>();
builder.Services.AddTransient<IRepository<Appointment>, AppointmentRepository>();

builder.Services.AddTransient<IServiceLogic, ServiceLogic>();
builder.Services.AddTransient<IPostLogic, PostLogic>();
builder.Services.AddTransient<IAppointmentLogic, AppointmentLogic>();

builder.Services.AddControllersWithViews();

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
app.MapRazorPages();

app.Run();
