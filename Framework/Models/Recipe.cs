using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Framework.Models
{
    public class Recipe
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("amount")]
        public string Amount { get; set; }
        [JsonProperty("secPerOp")]
        public string SecPerOp { get; set; }
        [JsonProperty("processName")]
        public string ProcessName { get; set; }
        [JsonProperty("ingriedients")]
        public List<Ingredient> Ingredients { get; set; }
    }
}
