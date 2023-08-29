using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    internal class DeleteMovies
    {
        public DeleteMovies()

        {
            Console.Write("Enter the index of the movie to delete: ");
            int indexToDelete = int.Parse(Console.ReadLine()) - 1;
            if (indexToDelete >= 0 && indexToDelete < StaticArray.movieCount)
            {
                for (int i = indexToDelete; i < StaticArray.movieCount - 1; i++)
                {
                    StaticArray.moviesArray[i] = StaticArray.moviesArray[i + 1];
                }
                StaticArray.movieCount--;
                Console.WriteLine("Movie deleted!");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }

        }
    }


}
