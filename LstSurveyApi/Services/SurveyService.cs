using LstSurveyApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
        public ActionResult<Survey> CreateSurvey(Survey survey)
        {
            _context.Surveys.Add(survey);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetSurvey), new { id = survey.SurveyId }, survey);
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