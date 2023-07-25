
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Sovremennik.Data;
using Sovremennik.Models;
using System.Reflection;
using System.Xml.Linq;

var builder = WebApplication.CreateBuilder(args);

// ��������� ��������� ������������ � �� ������������� MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ������������� ������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// ����������� � ��
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

using (ApplicationContext db = new ApplicationContext(connection))
{
    // ������� ��� ������� User
    User tom = new User { Name = "Tom"};
    User alice = new User { Name = "Alice"};

    // ��������� �� � ��
    db.Users.Add(tom);
    db.Users.Add(alice);
    db.SaveChanges();
    Console.WriteLine("������� ������� ���������");

    // �������� ������� �� �� � ������� �� �������
    var users = db.Users.ToList();
    Console.WriteLine("������ ��������:");
    foreach (User u in users)
    {
        Console.WriteLine($"{u.Id}.{u.Name}");
    }
}

app.Run();