using NUnit.Framework;
namespace Readify.Puzzle.Web.Resource.Api.Controllers.Tests
{
    [TestFixture()]
    public class TriangleTypeControllerTests
    {
        private TriangleTypeController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new TriangleTypeController();
        }

        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 2, 3)]
        [TestCase(0, 0, 0)]
        public void GetTest(int a, int b, int c)
        {
            var result = _controller.Get(a, b, c);
            var contentResult = ((System.Web.Http.Results.OkNegotiatedContentResult<string>)(result)).Content;
            if (!string.IsNullOrWhiteSpace(contentResult))
            {
                switch (contentResult)
                {
                    case "Equilateral":
                        Assert.True(a == b && b == c);
                        break;
                    case "Isoceles":
                        Assert.True((a == b) || (b == c) || (a == c));
                        break;
                    case "Scalene":
                        Assert.True((a != b) || (b != c) || (a != c));
                        break;
                    case "Error":
                        Assert.True((a >= b + c) || (b >= a + c) || (c >= a + b) || (a <= 0) || (b <= 0) || (c <= 0));
                        break;
                }
            }
        }
    }
}
