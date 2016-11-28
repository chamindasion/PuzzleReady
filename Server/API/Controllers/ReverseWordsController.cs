using System;
using System.Text;
using System.Web.Http;

namespace Readify.Puzzle.Web.Resource.Api.Controllers
{
    [RoutePrefix("api/ReverseWords")]
    public class ReverseWordsController : ApiController
    {
        public IHttpActionResult Get(string sentence)
        {
            var reversedSentence = new StringBuilder();
            var charactersArray = sentence.ToCharArray();
            var tempWord = new StringBuilder();
            foreach (var character in charactersArray)
            {
                if (char.IsWhiteSpace(character))
                {
                    if (tempWord.Length >= 1)
                    {
                        ReverseAndAdd(tempWord, reversedSentence);
                        tempWord = new StringBuilder();
                    }
                    reversedSentence.Append(character);
                }
                else
                {
                    tempWord.Append(character);
                }
            }
            if (tempWord.Length >= 1)
                ReverseAndAdd(tempWord, reversedSentence);
            return Ok(Convert.ToString(reversedSentence));
        }

        private static void ReverseAndAdd(StringBuilder tempWord, StringBuilder reversedSentence)
        {
            var tempWordCharAray = (tempWord.ToString()).ToCharArray();
            Array.Reverse(tempWordCharAray);
            reversedSentence.Append(tempWordCharAray);
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
