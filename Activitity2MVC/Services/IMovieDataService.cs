using Activitity2MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activitity2MVC.Services
{
    interface IMovieDataService
    {
        List<MovieModel> GetAllMovies();
        MovieModel GetMovieByTitle(string title);

        int Insert(MovieModel movie);
        int Delete(MovieModel movie);
        int Update(MovieModel movie);

    }
}
