using NUnit.Framework;
using System;
namespace Readify.Puzzle.Web.Resource.Api.Controllers.Tests
{
    [TestFixture()]
    public class FibonacciControllerTests
    {
        private FibonacciController _controller;

        [SetUp]
        public void SetUp()
        {
            _controller = new FibonacciController();
        }

        [TestCase(-4)]
        [TestCase(-3)]
        [TestCase(-2)]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void GetTest(int n)
        {
            var result = _controller.Get(n);
            var contentResult = ((System.Web.Http.Results.OkNegotiatedContentResult<int>)(result)).Content;
            var convertedResult = 0;
            if (int.TryParse(Convert.ToString(contentResult), out convertedResult))
            {
                switch (n)
                {
                    case -4:
                        Assert.True(convertedResult == -3);
                        break;
                    case -3:
                        Assert.True(convertedResult == 2);
                        break;
                    case -2:
                        Assert.True(convertedResult == -1);
                        break;
                    case -1:
                        Assert.True(convertedResult == 1);
                        break;
                    case 0:
                        Assert.True(convertedResult == 0);
                        break;
                    case 1:
                        Assert.True(convertedResult == 1);
                        break;
                    case 2:
                        Assert.True(convertedResult == 1);
                        break;
                    case 3:
                        Assert.True(convertedResult == 2);
                        break;
                    case 4:
                        Assert.True(convertedResult == 3);
                        break;
                    case 5:
                        Assert.True(convertedResult == 5);
                        break;
                }
            }
        }
    }
}
