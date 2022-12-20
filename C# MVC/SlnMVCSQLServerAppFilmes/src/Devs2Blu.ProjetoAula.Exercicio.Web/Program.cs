using Devs2Blu.ProjetoAula.Exercicio.Web.Models;
using Devs2Blu.ProjetoAula.Exercicio.Web.Repository;
using Devs2Blu.ProjetoAula.Exercicio.Web.Services.Implements;
using Devs2Blu.ProjetoAula.Exercicio.Web.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Context DB SQL Server
builder.Services.AddDbContext<ContextoDatabase>
    (options => options.UseSqlServer("Server=DESKTOP-JB24L2U;Database=CatalogoFilmes;User Id=sa;Password=admin;"));

/*
 * Dependency Injection
 */

// Repositories
builder.Services.AddScoped<CategoriaRepository, CategoriaRepository>();

// Services
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

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
