using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace WTMovie.JSonClasses.AlloCineMovie{

    
    [Serializable]
     class AlloCineMovie {

        public Movie Movie { get; set; }

        //Empty Constructor
        public AlloCineMovie(){}

        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
        public static AlloCineMovie FromJson(string json)
        {
            return JsonConvert.DeserializeObject<AlloCineMovie>(json);
        }
    }


    [Serializable]
     class MovieType {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public MovieType(){}

    }


    [Serializable]
     class Nationality {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public Nationality(){}

    }


    [Serializable]
     class Genre {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public Genre(){}

    }


    [Serializable]
     class Country {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public Country(){}

    }


    [Serializable]
     class ReleaseState {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public ReleaseState(){}

    }


    [Serializable]
     class Distributor {

        public int Code { get; set; }
        public string Name { get; set; }

        //Empty Constructor
        public Distributor(){}

    }


    [Serializable]
     class Release {

        public string ReleaseDate { get; set; }
        public string ReissueDate { get; set; }
        public Country Country { get; set; }
        public ReleaseState ReleaseState { get; set; }
        public Distributor Distributor { get; set; }

        //Empty Constructor
        public Release(){}

    }


    [Serializable]
     class CastingShort {

        public string Directors { get; set; }
        public string Actors { get; set; }

        //Empty Constructor
        public CastingShort(){}

    }


    [Serializable]
     class Person {

        public int Code { get; set; }
        public string Name { get; set; }

        //Empty Constructor
        public Person(){}

    }


    [Serializable]
     class Activity {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public Activity(){}

    }


    [Serializable]
     class Picture {

        public string Name { get; set; }
        public string Path { get; set; }
        public string Href { get; set; }

        //Empty Constructor
        public Picture(){}

    }


    [Serializable]
     class CastMember {

        public Person Person { get; set; }
        public Activity Activity { get; set; }
        public Picture Picture { get; set; }
        public string Role { get; set; }

        //Empty Constructor
        public CastMember(){}

    }


    [Serializable]
     class Poster {

        public string Name { get; set; }
        public string Href { get; set; }

        //Empty Constructor
        public Poster(){}

    }


    [Serializable]
     class Trailer {

        public string Name { get; set; }
        public int Code { get; set; }
        public string Href { get; set; }

        //Empty Constructor
        public Trailer(){}

    }


    [Serializable]
     class Link {

        public string Rel { get; set; }
        public string Name { get; set; }
        public string Href { get; set; }

        //Empty Constructor
        public Link(){}

    }


    [Serializable]
     class Rating {

        public double Note { get; set; }
        public int Dollar { get; set; }

        //Empty Constructor
        public Rating(){}

    }


    [Serializable]
     class Statistics {

        public double PressRating { get; set; }
        public int PressReviewCount { get; set; }
        public double UserRating { get; set; }
        public int UserReviewCount { get; set; }
        public int UserRatingCount { get; set; }
        public int CommentCount { get; set; }
        public int PhotoCount { get; set; }
        public int VideoCount { get; set; }
        public Rating[] Rating { get; set; }
        public int FanCount { get; set; }
        public int ReleaseWeekPosition { get; set; }
        public int TheaterCount { get; set; }
        public int TheaterCountOnRelease { get; set; }

        //Empty Constructor
        public Statistics(){}

    }


    [Serializable]
     class Publication {

        public string DateStart { get; set; }

        //Empty Constructor
        public Publication(){}

    }


    [Serializable]
     class Picture2 {

        public string Path { get; set; }
        public string Href { get; set; }

        //Empty Constructor
        public Picture2(){}

    }


    [Serializable]
     class Category {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public Category(){}

    }


    [Serializable]
     class News {

        public int Code { get; set; }
        public Publication Publication { get; set; }
        public string Title { get; set; }
        public Picture2 Picture { get; set; }
        public Category[] Category { get; set; }

        //Empty Constructor
        public News(){}

    }


    [Serializable]
     class Publication2 {

        public string DateStart { get; set; }

        //Empty Constructor
        public Publication2(){}

    }


    [Serializable]
     class Picture3 {

        public string Path { get; set; }
        public string Href { get; set; }

        //Empty Constructor
        public Picture3(){}

    }


    [Serializable]
     class Category2 {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public Category2(){}

    }


    [Serializable]
     class Feature {

        public int Code { get; set; }
        public Publication2 Publication { get; set; }
        public string Title { get; set; }
        public Picture3 Picture { get; set; }
        public Category2[] Category { get; set; }

        //Empty Constructor
        public Feature(){}

    }


    [Serializable]
     class Publication3 {

        public string DateStart { get; set; }

        //Empty Constructor
        public Publication3(){}

    }


    [Serializable]
     class Trivia {

        public int Code { get; set; }
        public Publication3 Publication { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        //Empty Constructor
        public Trivia(){}

    }


    [Serializable]
     class Tag {

        public int Code { get; set; }
        public string Dollar { get; set; }

        //Empty Constructor
        public Tag(){}

    }


    [Serializable]
     class Movie {

        public int Code { get; set; }
        public MovieType MovieType { get; set; }
        public string OriginalTitle { get; set; }
        public string Title { get; set; }
        public string Keywords { get; set; }
        public int ProductionYear { get; set; }
        public Nationality[] Nationality { get; set; }
        public Genre[] Genre { get; set; }
        public Release Release { get; set; }
        public int Runtime { get; set; }
        public string Synopsis { get; set; }
        public string SynopsisShort { get; set; }
        public CastingShort CastingShort { get; set; }
        public CastMember[] CastMember { get; set; }
        public Poster Poster { get; set; }
        public Trailer Trailer { get; set; }
        public Link[] Link { get; set; }
        public Statistics Statistics { get; set; }
        public News[] News { get; set; }
        public Feature[] Feature { get; set; }
        public Trivia[] Trivia { get; set; }
        public Tag[] Tag { get; set; }

        //Empty Constructor
        public Movie(){}

    }

}