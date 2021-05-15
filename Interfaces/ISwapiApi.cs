using Refit;
using sovtechassignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sovtechassignment.Interfaces
{
    /// <summary>
    /// Inteface to handle the swapi requests using the Refit library wrapper.
    /// </summary>
    interface ISwapiApi
    {
        /// <summary>
        /// handle the jokes categories get request.
        /// 
        /// </summary>
        /// <returns>returns a list of strings</returns>
        [Get("/api/people/1/")]
        Task<SwapiPeopleResponse> StarWarsPeople();
    }
}
