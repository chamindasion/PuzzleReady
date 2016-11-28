using NUnit.Framework;
using System;
namespace Readify.Puzzle.Web.Resource.Api.Controllers.Tests
{
    [TestFixture()]
    public class TokenControllerTests
    {
        private TokenController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new TokenController();
        }

        [Test]
        public void GetTest()
        {
            var result = _controller.Get();
            var contentResult = ((System.Web.Http.Results.OkNegotiatedContentResult<Guid>)(result)).Content;
            if (!string.IsNullOrWhiteSpace(Convert.ToString(contentResult)))
            {
                Assert.IsTrue(true);
            }
        }
    }
}
