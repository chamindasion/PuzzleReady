using NUnit.Framework;
namespace Readify.Puzzle.Web.Resource.Api.Controllers.Tests
{
    [TestFixture()]
    public class ReverseWordsControllerTests
    {
        private ReverseWordsController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new ReverseWordsController();
        }

        [TestCase("iamaboy")]
        [TestCase("i am a boy")]
        [TestCase("i  am  a  boy")]
        [TestCase("i     am     a     boy")]
        [TestCase(" ")]
        [TestCase("")]
        public void GetTest(string sentence)
        {
            var result = _controller.Get(sentence);
            var contentResult = ((System.Web.Http.Results.OkNegotiatedContentResult<string>)(result)).Content;
            //if (!string.IsNullOrWhiteSpace(contentResult))
            //{
            switch (sentence)
            {
                case "iamaboy":
                    Assert.True(contentResult.Equals("yobamai"));
                    break;
                case "i am a boy":
                    Assert.True(contentResult.Equals("i ma a yob"));
                    break;
                case "i  am  a  boy":
                    Assert.True(contentResult.Equals("i  ma  a  yob"));
                    break;
                case "i     am     a     boy":
                    Assert.True(contentResult.Equals("i     ma     a     yob"));
                    break;
                case " ":
                    Assert.True(contentResult.Equals(" "));
                    break;
                case "":
                    Assert.True(contentResult.Equals(""));
                    break;
            }
            //}
        }
    }
}
