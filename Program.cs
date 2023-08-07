using iglesia.Data;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
 builder.Services.AddDbContext<TuDbContext>(options =>
        {
            // Configurar la cadena de conexión a PostgreSQL
            string connectionString = "Server=db-postgresql-sfo3-27842-do-user-14418275-0.b.db.ondigitalocean.com;Port=25060;Database=defaultdb;User Id=doadmin;Password=AVNS_27FnDiPzLYBGJGLz8gQ";
            options.UseNpgsql(connectionString);
        });
// Add services to the container.
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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
