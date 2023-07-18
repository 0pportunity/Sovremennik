var builder = WebApplication.CreateBuilder(args);

// добавляем поддержку контроллеров и их представлений MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// маршрутизация контроллеров
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

// изменение для БД