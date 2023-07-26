
using Sovremennik.Data;

var builder = WebApplication.CreateBuilder(args);

// ��������� ��������� ������������ � �� ������������� MVC
builder.Services.AddControllersWithViews();

// ��������� �������� 
builder.Services.AddDbContext<ApplicationContext>();

var app = builder.Build();

// ������������� ������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();