using Activitity2MVC.Models;
using Activitity2MVC.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activitity2MVC.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            HardCodedMovieDepository hardCodedMovieDepository = new HardCodedMovieDepository();

            return View(hardCodedMovieDepository.GetAllMovies());
        }
    }
}
