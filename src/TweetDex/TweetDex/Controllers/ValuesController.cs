namespace TweetDex.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Core.Services;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ITweetService tweetService;

        public ValuesController(ITweetService tweetService)
        {
            this.tweetService = tweetService;
        }
        // GET api/values
        [HttpGet]
        public IActionResult Get() => Ok(tweetService.GetMostRecentTweet());

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
