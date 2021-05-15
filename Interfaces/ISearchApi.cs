using Refit;
using sovtechassignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sovtechassignment.Interfaces
{
    interface ISearchJokesApi
    {
        [Get("/jokes/search?query={searchTerm}")]
        Task<JokeSearchResponse> SearchJokes([AliasAs("searchTerm")] string searchTerm);
    }

    interface ISearchPeopleApi
    {
        [Get("/api/people/?search={searchTerm}")]
        Task<PeopleSearchResponse> SearchPeople([AliasAs("searchTerm")] string searchTerm);
    }
}
