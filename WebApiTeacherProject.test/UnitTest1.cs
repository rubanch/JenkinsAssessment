using Microsoft.AspNetCore.Http.HttpResults;
using WebApiWithController.Controllers;
using WebApiWithController.Models;
namespace WebApiQuizProject.test
{
    public class Tests
    {
        private QuizController controller;
        [SetUp]
        public void Setup()
        {
            controller = new QuizController();
        }

        [Test]
        public void TestMethodForGetQuestions()
        {
            IEnumerable<QuizModel> result = controller.GetQuestions();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostQuestions()
        {
            var newItem = new QuizModel
            {
                Question_No = 1,
                Question_Text = "test",
                Question_Category = "test",
                Question_Answer = "test"
            };
            var actionResult = controller.PostQuestions(newItem);
            Assert.That(actionResult, Is.Not.Null);
            
        }
        [Test]
        public void TestMethodForPostQuestionNull()
        {
            var newItem = new QuizModel
            {
                Question_No = 1,
                Question_Text = null,
                Question_Category = null,
                Question_Answer = null
            };
            var actionResult = controller.PostQuestions(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}