using LstSurveyApi.Context;
using LstSurveyApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LstSurveyApi.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly QuestionContext _questionContext;

        public QuestionController(QuestionContext questionContext)
        {
            _questionContext = questionContext;
        }
        [HttpGet]
        public IActionResult GetQuestions() 
        {
            var questions = _questionContext.Question.ToList();

            return Ok(questions);
        }
        [HttpGet("{id}")]
        public ActionResult<Question> GetQuestions(int id)
        {
            var question = _questionContext.Question.Find(id);
            if(question == null)
            {
                return NotFound();
            }
            return Ok(question);
        }
        [HttpPost]
        public ActionResult<Question> CreateQuestion(Question question)
        {
                _questionContext.Question.Add(question);
                _questionContext.SaveChanges();
            return CreatedAtAction(nameof(GetQuestions), question);
        }
    }
}
