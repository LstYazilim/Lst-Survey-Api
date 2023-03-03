using LstSurveyApi.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LstSurveyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OptionController : ControllerBase
    {
        private readonly OptionContext _optionContext;

        public OptionController(OptionContext optionContext)
        {
            _optionContext = optionContext;
        }

        [HttpGet]
        public IActionResult GetOptions() 
        {
            var options = _optionContext.Options.ToList();

            return Ok(options);
        }
    }
}
