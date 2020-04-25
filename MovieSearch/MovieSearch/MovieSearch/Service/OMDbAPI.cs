using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using MovieSearch.Model;
using Newtonsoft.Json;

namespace MovieSearch.Service
{
    public class OMDbAPI
    {
        private static string apiURL = "http://www.omdbapi.com/?t={0}&apikey=255a9abf";

        public static Movie.Rootobject BuscaFilme (string movie)
        {
            string completeURL = string.Format(apiURL, movie);

            WebClient wb = new WebClient();
            var result = wb.DownloadString(completeURL);

            Movie.Rootobject mv = JsonConvert.DeserializeObject<Movie.Rootobject>(result);

            return mv;
        }
    }
}
