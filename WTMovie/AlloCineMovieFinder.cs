using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WTMovie.JSonClasses.AlloCineMovie;
using WTMovie.JSonClasses.AlloCineMovieId;
using System.Net;
using System.IO;

namespace WTMovie
{
    public class AlloCineMovieFinder : IMovieFinder
    {
        public AlloCineMovieFinder()
        {

        }

        public SimpleMovie FindMovie(string movieName)
        {
            string text = GetJSon("http://api.allocine.fr/rest/v3/search?partner=YW5kcm9pZC12M3M&filter=movie&count=1&page=1&q=" + movieName + "&format=json");


            AlloCineMovieId alloCineMovieId = AlloCineMovieId.FromJson(text);
            int code = alloCineMovieId.Feed.Movie[0].Code;

            text = string.Empty;
            text = GetJSon("http://api.allocine.fr/rest/v3/movie?partner=YW5kcm9pZC12M3M&code=" + code + "&profile=medium&mediafmt=mp4-lc&format=json&filter=movie&striptags=synopsis,synopsisshort");

            AlloCineMovie alloCineMovie = AlloCineMovie.FromJson(text);

            return CreateSimpleMovie(alloCineMovie.Movie);
            
        }

        private SimpleMovie CreateSimpleMovie(JSonClasses.AlloCineMovie.Movie movie)
        {
            SimpleMovie simpleMovie = new SimpleMovie();

            simpleMovie.Title = movie.Title;
            simpleMovie.Synopsis = movie.Synopsis;
            simpleMovie.ShortSynopsis = movie.SynopsisShort;
            string[] date = movie.Release.ReleaseDate.Split('-');
            int[] dateInt = {0,0,0};
            for (int i = 0; i < date.Count(); i++)
			{
                 Int32.TryParse(date[i],out dateInt[i]);
			}
            simpleMovie.ReleaseDate = new DateTime(dateInt[0], dateInt[1], dateInt[2]);
            //simpleMovie.ReleaseDate = DateTime.TryParse(movie.Release.ReleaseDate,,out simpleMovie.ReleaseDate);
            simpleMovie.ProductionYear = movie.ProductionYear;
            simpleMovie.PosterLink = movie.Poster.Href;
            simpleMovie.OriginalTitle = movie.OriginalTitle;
            
            return simpleMovie;
        }


        string GetJSon(string url)
        {
            WebRequest request = WebRequest.Create(url);
            string text;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }

            return text;
        }        
    }
}
