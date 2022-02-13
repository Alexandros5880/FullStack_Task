using AutoMapper;
using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Areas.Identity.Models.ViewModels;
using FullStack_Task.HorizontalClasses.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

        [HttpPost("Register")]
        public async Task<IActionResult> Register(ApplicationUserViewModel viewModel)
        {
            if (viewModel == null)
                return BadRequest();

            // Create ApplicationUser
            ApplicationUser user = this._mapper.Map<ApplicationUser>(viewModel);
            await this._db.Users.Add(user);
            await this._db.Save();

            // Buisness Areas
            List<BusinessArea> bareas = new List<BusinessArea>();
            foreach (int areaId in viewModel.BAreas)
            {
                var businseArea = await this._db.BuisnessAreas.GetEmpty(areaId);
                if (businseArea.Users == null)
                    businseArea.Users = new List<ApplicationUser>();
                businseArea.Users.Add(user);
            }
            user.BusinessAreas = bareas;
            await this._db.Save();

            // Create Comment
            Comment comment = this._mapper.Map<Comment>(viewModel);
            await this._db.Comments.Add(comment);
            comment.User = user;

            // Create Address
            Address address = this._mapper.Map<Address>(viewModel);
            address.User = user;
            await this._db.Address.Add(address);
            await this._db.Save();

            return Ok(user);
        }

    }
}
