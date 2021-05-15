using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sovtechassignment.Models
{
    public class SearchResponse
    {
        public JokeSearchResponse JokeSearchResponse { get;set;}
        public PeopleSearchResponse PeopleSearchResponse { get; set; }
    }
}
