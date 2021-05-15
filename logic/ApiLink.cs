using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sovtechassignment.logic
{
    public class ApiLink
    {
        private static string url;
        public static string JokeCategoresUrl { 
            get { 
                return "https://api.chucknorris.io"; 
            } 
            set { 
                value = url; 
            } 
        }

        public static string StarWarsPeopleUrl
        {
            get
            {
                return "https://swapi.dev";
            }
            set
            {
                value = url;
            }
        }
    }
}
