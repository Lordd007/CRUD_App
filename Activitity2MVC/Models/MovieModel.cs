using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Activitity2MVC.Models
{
    public class MovieModel
    {
        [DisplayName("Id number")]
        public int Id { get; set; }
        [DisplayName("Movie Title")]
        public string Title { get; set; }
        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [DisplayName("Gross Sales (in millions")]
        [DataType(DataType.Currency)]
        public decimal GrossSales { get; set; }
        [DisplayName("Average Rating")]
        public decimal Rating { get; set; }

    }
}
