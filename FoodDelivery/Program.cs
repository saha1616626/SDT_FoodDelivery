using Data;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;

var builder = WebApplication.CreateBuilder(args);

// добавляет в контейнер зависимостей службу базы данных и настраивает подключение к SQL Server через строку подключения из конфигурации приложения
builder.Services.AddDbContext<Contex>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DeliveryFoodConection")
    ?? throw new InvalidOperationException("Connection string 'RazorPagesMovieContext' not found.")));

// Add services to the container.
builder.Services.AddRazorPages();

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
