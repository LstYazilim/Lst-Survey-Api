using LstSurveyApi.Context;
using LstSurveyApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



using static LstSurveyApi.Context.QuestionContext;

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
        public async Task<ActionResult<QuestionOptionDto>> GetQuestionsWithOptions(int questionId)
        {
            var question = await _questionContext.Question
                .Include(q => q.QuestionUnitSurveys)
                .ThenInclude(qus => qus.Question)
                .FirstOrDefaultAsync(q => q.QuestionId == questionId);

            if (question == null) { return NotFound(); }

            var optionsDto = question.QuestionUnitSurveys.Select(qus => qus.Question)
                .Select(o => new OptionDto
                {
                    OptionText = o.QuestionText,
                }).ToList();

            var questionDto = new QuestionOptionDto
            {
                QuestionId = question.QuestionId,
                QuestionText = question.QuestionText,
                UpdaterUser = question.UpdaterUser,
                OptionTexts = optionsDto.Select(o => o.OptionText).ToList()
            };

            return Ok(questionDto);
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
