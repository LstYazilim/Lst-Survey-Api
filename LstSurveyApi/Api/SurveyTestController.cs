using LstSurveyApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LstSurveyApi.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyTestController : ControllerBase
    {
        
        // GET: api/<SurveyTestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<SurveyTestController>/5
        [HttpGet("{id}")]
        public string Get(int SurveyId)
        {
            return "value";
        }

        // POST api/<SurveyTestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<SurveyTestController>/5
        [HttpPut("{id}")]
        public void Put(int SurveyId, [FromBody] string value)
        {
        }

        // DELETE api/<SurveyTestController>/5
        [HttpDelete("{id}")]
        public void Delete(int SurveyId)
        {
        }
    }
}
