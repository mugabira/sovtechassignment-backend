using System.Collections.Generic;

namespace sovtechassignment.Models
{
    public class PeopleSearchResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<SwapiPeopleResponse> results { get; set; }
}
}