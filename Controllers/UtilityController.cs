using MatchPredict.Helpers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MatchPredict.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilityController : ControllerBase
    {
        [Route("GetTeams")]
        [HttpGet]
        public List<Team> GetTeams()
        {
            using (StreamReader r = new StreamReader("JSONdb\\" + "teams.json"))
            {
                string jsonstring = r.ReadToEnd();
                var jsonResp = JObject.Parse(jsonstring);
                var teams = jsonResp.ToObject<Teams>();
                return teams.teams.OrderBy(x => x.teamName).ToList();
            }
        }
    }
}
