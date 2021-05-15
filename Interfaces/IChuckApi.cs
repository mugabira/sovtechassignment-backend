using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sovtechassignment.Interfaces
{
    interface IChuckApi
    {
        [Get("/jokes/categories")]
        Task<IEnumerable<string>> JokeCategories();
    }
}
