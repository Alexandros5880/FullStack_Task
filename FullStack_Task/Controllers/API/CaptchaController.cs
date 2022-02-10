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

        [HttpGet]
        public IActionResult GetCaptchaImage()
        {
            int width = 300;
            int height = 100;
            var captchaCode = Captcha.GenerateCaptchaCode();
            var result = Captcha.GenerateCaptchaImage(width, height, captchaCode);
            HttpContext.Session.SetString("CaptchaCode", result.CaptchaCode);
            Stream s = new MemoryStream(result.CaptchaByteData);
            return new FileStreamResult(s, "image/png");
        }

    }
}
