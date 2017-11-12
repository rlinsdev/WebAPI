using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Controller
{
    public class HelloController : ApiController
    {
        // GET: api/Hello
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

		// GET: api/Hello/5
		[HttpGet]
		[Route("api/Hello/{id}")]
		public string Get(int id)
		{
			return "value";
		}

		[HttpGet]
		[Route("api/Hello/{valOne}/{valTwo}")]
		public string GetMoreParam(int valOne, int valTwo)
		{
			return "value with two params";
		}

		// POST: api/Hello
		public void Post([FromBody]string value)
        {
        }

        // PUT: api/Hello/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Hello/5
        public void Delete(int id)
        {
        }
    }
}
