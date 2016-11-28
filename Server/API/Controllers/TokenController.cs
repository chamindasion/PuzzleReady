using System;
using System.Web.Http;

namespace Readify.Puzzle.Web.Resource.Api.Controllers
{
    [RoutePrefix("api/Token")]
    public class TokenController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(new Guid("e8e85af6-c8ca-4584-bb12-38156f891c38"));
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
