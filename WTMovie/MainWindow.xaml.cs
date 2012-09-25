using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using System.Diagnostics;

using Newtonsoft.Json;
using WTMovie.JSonClasses.AlloCineMovieId;
using WTMovie.JSonClasses.AlloCineMovie;

namespace WTMovie
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string movieName = "Avatar";

            string text = GetJSon("http://api.allocine.fr/rest/v3/search?partner=YW5kcm9pZC12M3M&filter=movie&count=1&page=1&q=" + movieName + "&format=json");


            AlloCineMovieId alloCineMovieId = AlloCineMovieId.FromJson(text);
            int code = alloCineMovieId.Feed.Movie[0].Code;

            text = string.Empty;
            text = GetJSon("http://api.allocine.fr/rest/v3/movie?partner=YW5kcm9pZC12M3M&code=" + code + "&profile=medium&mediafmt=mp4-lc&format=json&filter=movie&striptags=synopsis,synopsisshort");
            
            AlloCineMovie alloCineMovie = AlloCineMovie.FromJson(text);

            ResultLabel.Content = "Avatar\n";
            ResultLabel.Content += "\nVersion courte :\n" + alloCineMovie.Movie.SynopsisShort;
            ResultLabel.Content += "\nVersion longue :\n" + alloCineMovie.Movie.Synopsis;

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
