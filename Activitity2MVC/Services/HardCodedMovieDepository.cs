using Activitity2MVC.Models;
using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activitity2MVC.Services
{
    public class HardCodedMovieDepository : IMovieDataService
    {
        
        static List<MovieModel> movieList = new List<MovieModel>();
        public int Delete(MovieModel movie)
        {
            throw new NotImplementedException();
        }

        public List<MovieModel> GetAllMovies()
        {

            if (movieList.Count == 0)
            {
                movieList.Add(new MovieModel { Id = 1, Title = "Jaws", ReleaseDate = new DateTime(2015, 12, 31), GrossSales = 190.23m, Rating = 4.5m });
                movieList.Add(new MovieModel { Id = 2, Title = "Harry Potter", ReleaseDate = new DateTime(2014, 5, 10), GrossSales = 190.23m, Rating = 2.5m });
                movieList.Add(new MovieModel { Id = 3, Title = "LOTR", ReleaseDate = new DateTime(2004, 10, 5), GrossSales = 890.23m, Rating = 4.7m });
                movieList.Add(new MovieModel { Id = 4, Title = "Star Wars", ReleaseDate = new DateTime(1975, 6, 1), GrossSales = 790.23m, Rating = 4.8m });

                for (int i = 0; i < 50; i++)
                {
                    movieList.Add(new Faker<MovieModel>()
                        .RuleFor(p => p.Id, i + 5)
                        .RuleFor(p => p.Title, f => f.Commerce.ProductName())
                        .RuleFor(p => p.ReleaseDate, f => f.Date.Between(new DateTime(1960, 01, 01), new DateTime(2020, 12, 31)))
                        .RuleFor(p => p.GrossSales, f => f.Random.Decimal(1000))
                        .RuleFor(p => p.Rating, f => f.Random.Decimal(5)));

                }

            }
            

            return movieList;
        }

        public MovieModel GetMovieByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public int Insert(MovieModel movie)
        {
            throw new NotImplementedException();
        }

        public int Update(MovieModel movie)
        {
            throw new NotImplementedException();
        }
    }
}
