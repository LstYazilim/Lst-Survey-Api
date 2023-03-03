using LstSurveyApi.Context;
using LstSurveyApi.Models;
using LstSurveyApi.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;


namespace LstSurveyApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserContext _userContext;
        
        public UserController(UserContext userContext)
        {
            _userContext = userContext;
        }

   
        [HttpGet]
        public IActionResult GetUserInfo()
        {
            var userInfo = _userContext.SurveyUser.ToList();
            return Ok(userInfo);
        }

       
    }
}
