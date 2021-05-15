using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filmopoisk.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Country { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public byte[] Poster { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }
        public Film()
        {
            Actors = new List<Actor>();
        }
    }
}