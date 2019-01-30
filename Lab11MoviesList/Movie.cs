using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11MoviesList
{
    class Movie
    {
        private string title;
        private string category;
        private string v;

        public Movie(string v)
        {
            this.v = v;
        }

        public Movie (string movieTitle, string movieCategory)
        {
            title = movieTitle;
            category = movieCategory;
        }
        
    }
}
