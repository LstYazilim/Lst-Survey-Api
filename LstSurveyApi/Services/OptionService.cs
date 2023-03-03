using LstSurveyApi.Context;
using LstSurveyApi.Models;
using System.Collections.Generic;
using System.Linq;
using System;


namespace LstSurveyApi.Services
{
    public class OptionService
    {
        private readonly OptionContext _optionContext;

        public OptionService(OptionContext optionContext)
        {
            _optionContext = optionContext;
        }
        public List<Option> GetOptions()
        {
            return _optionContext.Options.ToList();
        }
    }
}
