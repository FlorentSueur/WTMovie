using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTMovie
{
    public interface IMovieFinder
    {
        SimpleMovie FindMovie(string movieName);        
    }
}
