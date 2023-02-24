using LstSurveyApi.Context;
using LstSurveyApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
        [HttpGet("{unitId}")]
        public ActionResult<QuestionUnitSurvey> GetQuestionsByUnitId(int unitId)
        {

            var questions = _questionContext.QuestionUnitSurvey
    .Where(qus => qus.UnitId == unitId)
    .Select(qus => qus.Question.QuestionText)
    .ToList();
           
            if (questions == null || questions.Count == 0)
            {
                return NotFound();
            }

            return Ok(questions);
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
