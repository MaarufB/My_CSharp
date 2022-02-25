using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetterSetter
{
    public class Movie
    {
        public string title;
        public string director;
        private string rating;
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating 
        { 
            get { return rating; } // This will be returned
            set  // This will set the passed value and validate it first
            {
                if ( value == "G" || value == "PG" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
        
        
    }
}