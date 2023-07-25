
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sovremennik.Data;
using Sovremennik.Models;
using System.Reflection;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// добавляем поддержку контроллеров и их представлений MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// маршрутизация контроллеров
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// подключение к БД
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

using (ApplicationContext db = new ApplicationContext(connection))
{
    // создаем два объекта User
    User tom = new User { Name = "Tom"};
    User alice = new User { Name = "Alice"};

    // добавляем их в бд
    db.Users.Add(tom);
    db.Users.Add(alice);
    db.SaveChanges();
    Console.WriteLine("Объекты успешно сохранены");

    // получаем объекты из бд и выводим на консоль
    var users = db.Users.ToList();
    Console.WriteLine("Список объектов:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name}");
    }
}

app.Run();