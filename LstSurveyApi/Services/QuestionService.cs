using LstSurveyApi.Context;
using LstSurveyApi.Models;
using System.Collections.Generic;
using System.Linq;
using System;
namespace LstSurveyApi.Services
{
    public class QuestionService
    {
        private readonly QuestionContext _questionContext;

        public QuestionService(QuestionContext questionContext)
        {
            _questionContext = questionContext;
            
        }
        public List<Question> GetQuestions()
        {
            return _questionContext.Question.ToList();
        }
    }
}
