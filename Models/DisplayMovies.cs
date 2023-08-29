using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieApp.Models
{
    internal class DisplayMovies
    {
       public DisplayMovies() 
        {
            if(StaticArray.movieCount==0)
            {
                Console.WriteLine("array is null");
            }
            else {
                Console.WriteLine("List of Movies:");
                for (int i = 0; i < StaticArray.movieCount; i++)
                {
                    Console.WriteLine($"{i + 1}. {StaticArray.moviesArray[i]}");
                }
            }
          
        }

    }
}
