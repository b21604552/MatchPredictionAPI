
using System.Collections.Generic;

namespace MatchPredict
{
    public class MatchResult
    {
        public string home { get; set; }
        public string away { get; set; }
        public string winner { get; set; }
        public List<string> errorRate { get; set; }
        public List<string> statistic { get; set; }
    }

    public class Team
    {
        public string teamName { get; set; }
        public string cityName { get; set; }
        public string stadiumName { get; set; }
    }

    public class Teams
    {
        public List<Team> teams { get; set; }
    }
}
