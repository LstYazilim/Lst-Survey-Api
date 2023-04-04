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
        private readonly OptionContext _optionContext;

        public QuestionController(QuestionContext questionContext, OptionContext optionContext)
        {
            _questionContext = questionContext;
            _optionContext = optionContext;
        }
        [HttpGet("{questionId}/options")]
        public async Task<ActionResult<QuestionOptionDto>> GetQuestionsWithOptions(int questionId)
        {
            var question = await _questionContext.Question
                .Include(q => q.QuestionUnitSurveys)
                    .ThenInclude(qus => qus.Unit)
                .FirstOrDefaultAsync(q => q.QuestionId == questionId);

            if (question == null)
            {
                return NotFound();
            }
            var optionTexts = await _optionContext.Options
                .Where(o => o.QuestionId == questionId)
                .Select(o => o.OptionText)
                .ToListAsync();

            var dto = new QuestionOptionDto
            {
                QuestionId = question.QuestionId,
                QuestionText = question.QuestionText,
                UpdaterUser = question.UpdaterUser,
                OptionTexts = optionTexts
            };

            return dto;
        }
        [HttpGet("options")]
        public async Task<ActionResult<List<QuestionOptionDto>>> GetAllQuestionsWithOptions()
        {
            var questions = await _questionContext.Question
                .Include(q => q.QuestionUnitSurveys)
                    .ThenInclude(qus => qus.Unit)
                .ToListAsync();

            var optionTexts = await _optionContext.Options
                .Select(o => new { o.QuestionId, o.OptionText })
                .ToListAsync();

            var dtoList = questions.Select(question => new QuestionOptionDto
            {
                QuestionId = question.QuestionId,
                QuestionText = question.QuestionText,
                UpdaterUser = question.UpdaterUser,
                OptionTexts = optionTexts.Where(o => o.QuestionId == question.QuestionId).Select(o => o.OptionText).ToList()
            }).ToList();

            return dtoList;
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
        public ActionResult<List<QuestionDetails>> GetQuestionsByUnitId(int unitId)
        {
            var questionDetails = _questionContext.QuestionUnitSurvey
                .Where(qus => qus.UnitId == unitId)
                .Select(qus => new QuestionDetails
                {
                    QuestionId = qus.QuestionId,
                    QuestionText = qus.Question.QuestionText,
                    UpdaterUser = qus.Question.UpdaterUser
                })
                .ToList();

            // Retrieve the options and question IDs for each question
            foreach (var question in questionDetails)
            {
                var questionId = _questionContext.QuestionUnitSurvey
                    .Where(qus => qus.UnitId == unitId && qus.Question.QuestionText == question.QuestionText)
                    .Select(qus => qus.QuestionId)
                    .FirstOrDefault();

                var options = _optionContext.Options
                    .Where(o => o.QuestionId == questionId)
                    .Select(o => o.OptionText)
                    .ToList();

                question.Options = options; 
               // question.QuestionId = questionId;
            }

            return Ok(questionDetails);
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
