using FullStack_Task.Areas.Identity.Models.ViewModels;
using FullStack_Task.HorizontalClasses.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FullStack_Task.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AccountMController : Controller
    {
        private readonly IDBHundler _db;

        public AccountMController(IDBHundler dbHundler)
        {
            this._db = dbHundler;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            ViewData["Data"] = await this._db.Salutations.GetAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel viewModel)
        {
            return View();
        }

    }
}
