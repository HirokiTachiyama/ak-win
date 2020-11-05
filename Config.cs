using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ak_win
{
    [JsonObject("Config")]
    public class Config
    {
        [JsonProperty("todoUrl")]
        public string todoUrl { get; set; }
        
        [JsonProperty("todoUser")]
        public string todoUser { get; set; }

        [JsonProperty("todoPass")]
        public string todoPass { get; set; }

        [JsonProperty("todoPage")]
        public string todoPage { get; set; }

        [JsonProperty("redmineUrl")]
        public string redmineUrl { get; set; }

        [JsonProperty("redmineUser")]
        public string redmineUser { get; set; }

        [JsonProperty("redminePass")]
        public string redminePass { get; set; }

        [JsonProperty("redmineApiKey")]
        public string redmineApiKey { get; set; }
    }
}
