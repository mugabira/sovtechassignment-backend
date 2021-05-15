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
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class Swapi : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]/people")]
        public async Task<SwapiPeopleResponse> People()
        {
            var gitHubApi = RestService.For<ISwapiApi>(logic.ApiLink.StarWarsPeopleUrl);
            var response = await gitHubApi.StarWarsPeople();
            return (SwapiPeopleResponse)response;
        }
    }
}
