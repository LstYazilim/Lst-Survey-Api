using LstSurveyApi.Context;
using LstSurveyApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;

namespace LstSurveyApi.Services
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly SurveyContext _context;

        public SurveyController(SurveyContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetSurveys()
        {
            var surveys = _context.Surveys.ToList();
            return Ok(surveys);
        }

        [HttpGet("{id}")]
        public ActionResult<Survey> GetSurvey(int id)
        {
            var survey = _context.Surveys.Find(id);
            if (survey == null)
            {
                return NotFound();
            }
            return Ok(survey);
        }
        [HttpPost]
        public IActionResult CreateSurvey([FromBody] JsonElement json)
        {
            var survey = new Survey();

            if (json.TryGetProperty("survey_date", out var surveyDateElement))
            {
                if (surveyDateElement.ValueKind == JsonValueKind.String && DateTime.TryParse(surveyDateElement.GetString(), out var surveyDate))
                {
                    survey.SurveyDate = surveyDate;
                }
                else
                {
                    ModelState.AddModelError("survey_date", "Invalid date format");
                }
            }
            var random = new Random();
            survey.SurveyId = random.Next(10000, 100000);
            if (json.TryGetProperty("survey_name", out var surveyNameElement))
            {
                if (surveyNameElement.ValueKind == JsonValueKind.String)
                {
                    survey.SurveyName = surveyNameElement.GetString();
                }
                else
                {
                    ModelState.AddModelError("survey_name", "Invalid survey name");
                }
            }
            if (json.TryGetProperty("create_date", out var createDateElement))
            {
                if (createDateElement.ValueKind == JsonValueKind.String && DateTime.TryParse(createDateElement.GetString(), out var createDate))
                {
                    survey.CreateDate = createDate;
                }
                else
                {
                    ModelState.AddModelError("create_date", "Invalid date format");
                }
            }

            if (json.TryGetProperty("update_date", out var updateDateElement))
            {
                if (updateDateElement.ValueKind == JsonValueKind.String && DateTime.TryParse(updateDateElement.GetString(), out var updateDate))
                {
                    survey.UpdateDate = updateDate;
                }
                else
                {
                    ModelState.AddModelError("update_date", "Invalid date format");
                }
            }

            if (json.TryGetProperty("creater_user", out var createrUserElement))
            {
                if (createrUserElement.ValueKind == JsonValueKind.String)
                {
                    survey.CreaterUser = createrUserElement.GetString();
                }
                else
                {
                    ModelState.AddModelError("creater_user", "Invalid creater user");
                }
            }

            if (json.TryGetProperty("updater_user", out var updaterUserElement))
            {
                if (updaterUserElement.ValueKind == JsonValueKind.String)
                {
                    survey.UpdaterUser = updaterUserElement.GetString();
                }
                else
                {
                    ModelState.AddModelError("updater_user", "Invalid updater user");
                }
            }


            if (ModelState.IsValid)
            {
                _context.Surveys.Add(survey);
                _context.SaveChanges();
                return CreatedAtAction(nameof(GetSurvey), new { id = survey.SurveyId }, survey);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }
       
     

        [HttpPut("{id}")]
        public IActionResult UpdateSurvey(int id, Survey survey)
        {
            if (id != survey.SurveyId)
            {
                return BadRequest();
            }

            _context.Entry(survey).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSurvey(int id)
        {
            var survey = _context.Surveys.Find(id);
            if (survey == null)
            {
                return NotFound();
            }

            _context.Surveys.Remove(survey);
            _context.SaveChanges();

            return NoContent();
        }
    }
}