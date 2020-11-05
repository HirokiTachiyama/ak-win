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
        [JsonProperty("url")]
        public string url { get; set; }
        
        [JsonProperty("user")]
        public string user { get; set; }

        [JsonProperty("pass")]
        public string pass { get; set; }

        [JsonProperty("page")]
        public string todoPage { get; set; }
    }
}
