using Newtonsoft.Json;

namespace Capstone2.Classes
{
    public class PatternSearchResponse
    {
        [JsonProperty("patterns")]
        public List<Pattern> Patterns { get; set; }
    }
}
