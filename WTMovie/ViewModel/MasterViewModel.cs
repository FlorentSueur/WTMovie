using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using WTMovie.Model;
using System.Windows.Input;
using System.Windows.Forms;

namespace WTMovie.ViewModel
{
    public class MasterViewModel : ViewModelBase
    {

        private ObservableCollection<SimpleMovieViewModel> m_Movies;
        private List<string> m_ListNameMovie;
        private List<SimpleMovie> m_ListSimpleMovie;
        private MoviesDatabase m_MoviesDb;
        public MasterViewModel()
        {
            m_MoviesDb = new MoviesDatabase();
            FolderChooserCommand = new SimpleCommand(ChooseFolder);
            FindMoviesInternetCommand = new SimpleCommand(FindMoviesOnAlloCine);
            m_Movies = new ObservableCollection<SimpleMovieViewModel>();
            m_ListSimpleMovie = new List<SimpleMovie>();
        }

        private ICommand m_FolderChooserCommand;

        public ICommand FolderChooserCommand
        {
            get { return m_FolderChooserCommand; }
            set { m_FolderChooserCommand = value; }
        }

        private ICommand m_FindMoviesInternetCommand;

        public ICommand FindMoviesInternetCommand
        {
            get { return m_FindMoviesInternetCommand; }
            set { m_FindMoviesInternetCommand = value; }
        }


        public string SelectedPath { get; set; }
        
        public ObservableCollection<SimpleMovieViewModel> Movies
        {
            get { return m_Movies; }
        }

        private void FindMoviesOnAlloCine()
        {
            IMovieFinder movieFinder = new AlloCineMovieFinder();
            m_ListSimpleMovie.Clear();
            foreach (var item in m_MoviesDb.Movies)
            {
                m_ListSimpleMovie.Add(movieFinder.FindMovie(item));
            }   
        }

        private void ChooseFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult dr = folderBrowserDialog.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                SelectedPath = folderBrowserDialog.SelectedPath;
            }
            m_MoviesDb.FindMovies(SelectedPath, ".avi");
        }        
    }
}
