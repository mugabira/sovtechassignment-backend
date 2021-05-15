
using Microsoft.AspNetCore.Mvc;
using Refit;
using sovtechassignment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sovtechassignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Chuck : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]/categories")]
        public async Task<IEnumerable<string>> Categories() {
            var gitHubApi = RestService.For<IChuckApi>(logic.ApiLink.JokeCategoresUrl);
            var response = await gitHubApi.JokeCategories();
            return (IEnumerable<string>)response;
        }
    }
}
