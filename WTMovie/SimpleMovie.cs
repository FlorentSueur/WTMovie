using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTMovie
{
    public class SimpleMovie
    {
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string PosterLink { get; set; }
        public string Synopsis { get; set; }
        public string ShortSynopsis { get; set; }
        public int ProductionYear { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
