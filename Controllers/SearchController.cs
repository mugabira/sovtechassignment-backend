using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Refit;
using sovtechassignment.Interfaces;
using sovtechassignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sovtechassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Search : ControllerBase
    {
        [HttpGet]
        public async Task<SearchResponse> Categories(string searchTerm)
        {
            var searchPeopleApi = RestService.For<ISearchPeopleApi>(logic.ApiLink.StarWarsPeopleUrl);
            var responsePeopleSearch = await searchPeopleApi.SearchPeople(searchTerm);

            var searchJokesApi = RestService.For<ISearchJokesApi>(logic.ApiLink.JokeCategoresUrl);
            var responseJokesSearch = await searchJokesApi.SearchJokes(searchTerm);
            SearchResponse searchResponse = new SearchResponse();
            searchResponse.PeopleSearchResponse = responsePeopleSearch;
            searchResponse.JokeSearchResponse = responseJokesSearch;

            return searchResponse;
        }
    }
}
