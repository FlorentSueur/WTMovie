using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WTMovie.ViewModel
{
    public class SimpleMovieViewModel : ViewModelBase
    {
        private SimpleMovie m_SimpleMovie;

        public SimpleMovieViewModel(SimpleMovie movie)
        {
            SimpleMovie = movie;
        }

        public SimpleMovie SimpleMovie
        {
            get { return m_SimpleMovie; }
            set
            {
                m_SimpleMovie = value;
                OnPropertyChanged("SimpleMovie");
            }
        }

        private string m_Title;

        public string Title
        {
            get { return m_SimpleMovie.Title; }
            
        }

        private string m_PosterLink;

        public string PosterLink
        {
            get { return m_SimpleMovie.PosterLink; }
        }

        


    }
}
