using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MatchPredict.Helpers;

namespace MatchPredict.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PredictController : ControllerBase
    {
        [Route("GetResult")]
        [HttpGet]
        public List<MatchResult> Get(string home, string away)
        {
            List<MatchResult> stats = new List<MatchResult>();
            using (StreamReader r = new StreamReader("JSONdb\\" + "matchResults.json"))
            {
                string jsonstring = r.ReadToEnd();
                var jsonResp = JArray.Parse(jsonstring);
                stats = jsonResp.ToObject<List<MatchResult>>();
                var temp = stats.Where(x => x.home.Equals(home) && x.away.Equals(away)).ToList();
                return temp;
            }
        }
    }
}
