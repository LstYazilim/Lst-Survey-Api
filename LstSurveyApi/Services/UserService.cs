using LstSurveyApi.Context;
using LstSurveyApi.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace LstSurveyApi.Services
{
    public class UserService
    {
        private readonly UserContext _userContext;

        public UserService(UserContext userContext)
        {
            _userContext = userContext;
        }
        public List<SurveyUser> GetUsers()
        {
            return _userContext.SurveyUser.ToList();
        }
    }
}
