using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sovremennik.Data;
using Sovremennik.Models;

namespace Sovremennik.Controllers
{
    public class UserController : Controller
    {
        private ApplicationContext db;

        public UserController(ApplicationContext context)
        {
            db = context;
        }

        // получение всех пользователей
        public async Task<IActionResult> GetAll()
        {
            return View(await db.Users.ToListAsync());
        }

        // получение одного пользователя по Id
        public async Task<IActionResult> GetUser(int Id)
        {
            return View(await db.Users.FirstOrDefaultAsync(u => u.Id == Id));
        }

        public IActionResult Create()
        {
            return View();
        }

        // добавление пользователя (логика регистрации)
        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
