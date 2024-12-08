using Newtonsoft.Json;

namespace Capstone2.Classes
{
    public class Designer
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
