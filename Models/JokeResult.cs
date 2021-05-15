using System.Collections.Generic;

namespace sovtechassignment.Models
{
    public class JokeResult
    {
        public List<string> category { get; set; }
        public string created_at { get; set; }
        public string icon_url { get; set; }
        public string id { get; set; }
        public string updated_at { get; set; }
        public string url { get; set; }
        public string value { get; set; }
    }
}