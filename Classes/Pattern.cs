using Newtonsoft.Json;

namespace Capstone2.Classes
{
    public class Pattern
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("free")]
        public bool IsFree { get; set; }

        [JsonProperty("designer")]
        public Designer Designer { get; set; }
    }
}
