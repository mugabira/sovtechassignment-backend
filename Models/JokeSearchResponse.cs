using System.Collections.Generic;

namespace sovtechassignment.Models
{
    public class JokeSearchResponse
    {
       public int total { get; set; }
       public List<JokeResult> result { get; set; }
}
}