using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    internal class AddMovies
    {
      
        public AddMovies()
        {
            if (StaticArray.movieCount < StaticArray.moviesArray.Length)
            {
                Console.Write("Enter the movie name: ");
                string movieName = Console.ReadLine();
                StaticArray.moviesArray[StaticArray.movieCount] = movieName;
                StaticArray.movieCount++;
                Console.WriteLine("Movie added!");
            }
            else
            {
                Console.WriteLine("Movie list is full.");
            }


        }
    }
}
