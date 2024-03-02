using Microsoft.AspNetCore.Mvc;
using WebApiWithController.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiWithController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private static List<QuizModel> Questions = new List<QuizModel>{ };

        // GET: api/<QuizController>
        [HttpGet]
        public IEnumerable<QuizModel> GetQuestions()
        {
            return Questions;
        }

        [HttpPost]
        public IActionResult PostQuestions(QuizModel teacher)
        {
            Questions.Add(teacher);
            return Ok(teacher);
        }       
    }
}
