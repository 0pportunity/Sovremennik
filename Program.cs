
using Sovremennik.Data;

var builder = WebApplication.CreateBuilder(args);

// добавляем поддержку контроллеров и их представлений MVC
builder.Services.AddControllersWithViews();

// добавляем контекст 
builder.Services.AddDbContext<ApplicationContext>();

var app = builder.Build();

// маршрутизация контроллеров
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();