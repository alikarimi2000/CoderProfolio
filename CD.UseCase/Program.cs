using CD.Application;
using CD.ApplicationContracts.ProjectCategory;
using CD.Domain.ProjectCategoryAgg;
using CD.Infrastructure;
using CD.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<IProjectCategoryApplication, ProjectCategoryApplication>();
builder.Services.AddTransient<IProjectCategoryApplication, ProjectCategoryApplication>();
builder.Services.AddTransient<IProjectCategoryRepository, ProjectCategoryRepository>();
var connectionString = "Server=.;Database=Profolio;Trusted_Connection=True;TrustServerCertificate=True;User Id=DESKTOP-IT7PIRM\\ali;";
builder.Services.AddDbContext<EfContext>(x => x.UseSqlServer(connectionString));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
