using AutoMapper;
using FullStack_Task.Areas.Identity.Models;
using FullStack_Task.Areas.Identity.Models.ViewModels;
using FullStack_Task.HorizontalClasses;
using Microsoft.AspNetCore.Mvc;

namespace FullStack_Task.Areas.Identity.Controllers.API
{
    [Route("/identity/api/validation/v1")]
    [ApiController]
    public class RegistrationValidationController : ControllerBase
    {
        private readonly IMapper _mapper;

        public RegistrationValidationController(IMapper mapper)
        {
            this._mapper = mapper;
        }

        [HttpPost("ContactValid")]
        [ValidateAntiForgeryToken]
        public IActionResult ContactValid([FromForm] ContactValidViewModel obj)
        {
            if (obj == null)
                return BadRequest();
            ApplicationUser model = this._mapper.Map<ApplicationUser>(obj);
            if (ModelState.IsValid)
            {
                return Ok(model);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("AreasValid")]
        [ValidateAntiForgeryToken]
        public IActionResult AreasValid([FromForm] AreasValidViewModel obj)
        {
            if (obj == null)
                return BadRequest();
            ApplicationUser model = this._mapper.Map<ApplicationUser>(obj);
            if (ModelState.IsValid)
            {
                return Ok(true);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("AddressValid")]
        [ValidateAntiForgeryToken]
        public IActionResult AddressValid([FromForm] AddressValidViewModel obj)
        {
            if (obj == null)
                return BadRequest();
            ApplicationUser model = this._mapper.Map<ApplicationUser>(obj);
            if (ModelState.IsValid)
            {
                return Ok(true);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("PasswordValid")]
        [ValidateAntiForgeryToken]
        public IActionResult PasswordValid([FromForm] PasswordValidViewModel obj)
        {
            if (obj == null)
                return BadRequest();
            ApplicationUser model = this._mapper.Map<ApplicationUser>(obj);
            if (ModelState.IsValid)
            {
                return Ok(true);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPost("PasswordCaptCha")]
        [ValidateAntiForgeryToken]
        public IActionResult ValidateCaptCha([FromForm] PasswordValidViewModel obj)
        {
            if (ModelState.IsValid)
            {
                if (!Captcha.ValidateCaptchaCode(obj.CaptchaCode, HttpContext))
                {
                    return Ok(true);
                }
                return BadRequest(ModelState);
            }
            return BadRequest(ModelState);
        }
    }
}
