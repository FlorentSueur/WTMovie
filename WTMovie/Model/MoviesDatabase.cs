using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WTMovie.Model
{
    public class MoviesDatabase
    {
        public MoviesDatabase()
        {
            m_Movies = new List<string>();
        }
        private List<string> m_Movies;

        public List<string> Movies
        {
            get { return m_Movies; }
            set { m_Movies = value; }
        }

        public void FindMovies(string directoryPath, string extension)
        {
            DirectoryInfo dI = new DirectoryInfo(directoryPath);
            if (dI.Name != "Program Files" || dI.Name != "Windows")
            {

                try
                {
                    foreach (var file in dI.GetFiles().Where(f => f.Extension == extension))
                    {
                        this.m_Movies.Add(file.Name.Replace(extension,""));
                    }

                    foreach (var dir in dI.GetDirectories().Where(d => d.Exists))
                    {

                        if (dI.Name == directoryPath)
                        {
                            FindMovies(dI.FullName + dir.Name, extension);
                        }
                        else
                        {
                            FindMovies(dI.FullName + "\\" + dir.Name, extension);
                        }
                    }
                }
                catch (UnauthorizedAccessException e) { };
            }
        }
    }
}

