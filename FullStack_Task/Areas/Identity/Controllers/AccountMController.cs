using AutoMapper;
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
        private readonly IGeography _geography;
        private readonly IMapper _mapper;

        public AccountMController(IDBHundler dbHundler, IGeography geography, IMapper mapper)
        {
            this._db = dbHundler;
            this._geography = geography;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            ViewData["Salutations"] = await this._db.Salutations.GetAll();
            ViewData["Areas"] = await this._db.BuisnessAreas.GetAll();
            ViewData["Countries"] = await this._geography.GetCountries();
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
