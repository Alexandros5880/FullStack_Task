using FullStack_Task.HorizontalClasses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FullStack_Task.Controllers.API
{
    [Route("api/Captcha")]
    [ApiController]
    public class CaptchaController : ControllerBase
    {

        [HttpGet("")]
        public IActionResult GetCaptchaImage()
        {
            int width = 300;
            int height = 100;
            var result = Captcha.GenerateCaptchaImage(width, height);
            HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            Stream s = new MemoryStream(result.CaptchaByteData);
            return new FileStreamResult(s, "image/png");
        }

        [HttpGet("Validate")]
        public IActionResult ValidateCaptCha(string userCaptcha)
        {
            var captcha = HttpContext.Session.GetString("CaptchaCode");
            if (Captcha.ValidateCaptchaCode(userCaptcha, captcha))
            {
                return Ok(true);
            }
            return BadRequest(false);
        }
    }
}
