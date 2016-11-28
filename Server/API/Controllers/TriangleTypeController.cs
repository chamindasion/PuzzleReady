using System;
using System.Web.Http;

namespace Readify.Puzzle.Web.Resource.Api.Controllers
{
    [RoutePrefix("api/TriangleType")]
    public class TriangleTypeController : ApiController
    {
        public IHttpActionResult Get(int a, int b, int c)
        {
            var result = FindTriangle(a, b, c);
            return Ok(Convert.ToString(result));
        }

        private static TringleType FindTriangle(int a, int b, int c)
        {
            if ((a >= b + c) || (b >= a + c) || (c >= a + b) || (a <= 0) || (b <= 0) || (c <= 0))
            {
                return TringleType.Error;
            }
            if (a == b && b == c)
            {
                return TringleType.Equilateral;
            }
            if ((a == b) || (b == c) || (a == c))
            {
                return TringleType.Isoceles;
            }
            return TringleType.Scalene;
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

    public enum TringleType
    {
        Equilateral,
        Isoceles,
        Scalene,
        Error
    }
}
