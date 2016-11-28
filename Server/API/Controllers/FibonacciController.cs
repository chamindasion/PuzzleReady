using System.Web.Http;

namespace Readify.Puzzle.Web.Resource.Api.Controllers
{
    [RoutePrefix("api/Fibonacci")]
    public class FibonacciController : ApiController
    {
        public IHttpActionResult Get(int n)
        {
            var result = n < 0 ? GetFibonacciNumberForNegativeIndex(n) : GetFibonacciNumberForPositiveIndex(n);
            return Ok(result);
        }

        private static int GetFibonacciNumberForNegativeIndex(int n)
        {
            var result = 0;
            if (n == 0)
                return 0;
            if (n > -2)
                return 1;
            return result -= (GetFibonacciNumberForNegativeIndex(n + 1) - GetFibonacciNumberForNegativeIndex(n + 2));
        }

        private static int GetFibonacciNumberForPositiveIndex(int n)
        {
            var result = 0;
            if (n == 0)
                return 0;
            if (n <= 2)
                return 1;
            return result += (GetFibonacciNumberForPositiveIndex(n - 1) + GetFibonacciNumberForPositiveIndex(n - 2));
        }

        private bool _disposed;
        protected override void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                }
                _disposed = true;
            }
            base.Dispose(disposing);
        }
    }
}
