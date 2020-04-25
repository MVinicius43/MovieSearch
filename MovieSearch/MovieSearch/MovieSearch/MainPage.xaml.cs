using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MovieSearch.Model;
using MovieSearch.Service;

namespace MovieSearch
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            buttonBuscar.Clicked += SearchMovie;
        }

        private void SearchMovie(object send, EventArgs args)
        {
            string movieName = nomeFilme.Text;

            Movie.Rootobject movie = OMDbAPI.BuscaFilme(movieName);

            cartaz.Source = movie.Poster;
            sobreFilme.Text = "Title: " + movie.Title;
            sobreFilme.Text += "\n\nYear: " + movie.Year;
            sobreFilme.Text += "\n\nGenre: " + movie.Genre;
            sobreFilme.Text += "\n\nWriter: " + movie.Writer;
            sobreFilme.Text += "\n\nAwards: " + movie.Awards;
            sobreFilme.Text += "\n\nPlot: " + movie.Plot;
        }
    }
}
