using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WTMovie.JSonClasses.AlloCineMovieId{

    [Serializable]
     class AlloCineMovieId {

        public Feed Feed{ get; set; }

        //Empty Constructor
        public AlloCineMovieId(){}

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
        public static AlloCineMovieId FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AlloCineMovieId>(json);
        }
    }


    [Serializable]
     class Result {

        public string Type{ get; set; }
        public int Dollar{ get; set; }

        //Empty Constructor
        public Result(){}

    }


    [Serializable]
     class Release {

        public string ReleaseDate { get; set; }

        //Empty Constructor
        public Release(){}

    }


    [Serializable]
     class CastingShort {

        public string Directors { get; set; }
        public string Actors{ get; set; }

        //Empty Constructor
        public CastingShort(){}

    }


    [Serializable]
     class Statistics {

        public double PressRating{ get; set; }
        public double UserRating{ get; set; }

        //Empty Constructor
        public Statistics(){}

    }


    [Serializable]
     class Poster {

        public string Path{ get; set; }
        public string Href{ get; set; }

        //Empty Constructor
        public Poster(){}

    }


    [Serializable]
     class Link {

        public string Rel{ get; set; }
        public string Href{ get; set; }

        //Empty Constructor
        public Link(){}

    }


    [Serializable]
     class Movie {

        public int Code{ get; set; }
        public string OriginalTitle{ get; set; }
        public string Title{ get; set; }
        public int ProductionYear{ get; set; }
        public Release Release{ get; set; }
        public CastingShort CastingShort{ get; set; }
        public Statistics Statistics{ get; set; }
        public Poster Poster{ get; set; }
        public Link[] Link{ get; set; }

        //Empty Constructor
        public Movie(){}

    }


    [Serializable]
     class Feed {

        public int Page{ get; set; }
        public int Count{ get; set; }
        public Result[] Results{ get; set; }
        public int TotalResults{ get; set; }
        public Movie[] Movie{ get; set; }

        //Empty Constructor
        public Feed(){}

    }

}