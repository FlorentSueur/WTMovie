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
using System.Windows.Forms;
using WTMovie.ViewModel;

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

            Loaded += delegate
            {
                MasterViewModel masterViewModel = new MasterViewModel();

                masterView.DataContext = masterViewModel;
                detailView.DataContext = masterViewModel;
            };
        }       
    }
}
